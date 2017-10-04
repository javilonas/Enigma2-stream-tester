using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enigma2_stream_tester.Utils
{
    public class FileOperations
    {
        public string DirectoryPath;
        private readonly string _currentDirM3U = Directory.GetCurrentDirectory() + "\\m3u";
        private readonly Main _form;

        public FileOperations(Main form)
        {
            _form = form;
        }

        private string[] Sample()
        {
            try
            {
                var pathSample = Directory.GetCurrentDirectory() + "\\configs\\template.m3u";
                var lines = File.ReadAllLines(pathSample);
                return lines;
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.Message);
                return null;
            }
            
        }

        public void NewM3U(string newIp,string port,bool best)
        {
            try
            {
                var bestStreams = string.Empty;
                if (best) { bestStreams = "Best\\";}
                var template = Sample();
                var ip = string.Empty;
                foreach (var line in template)
                {
                    if (!line.StartsWith("http://")) continue;
                    var myUri = new Uri(line);
                    ip = Dns.GetHostAddresses(myUri.Host)[0].ToString();
                    break;
                }
                var c = 0;
                foreach (var line in template)
                {
                    template[c] = line.Replace(ip, newIp).Replace("8001", port).Replace("8002", port);
                    c += 1;
                }
                if (!Directory.Exists(_currentDirM3U) || !Directory.Exists(Directory.GetCurrentDirectory() + "\\m3u\\Best"))
                {
                    Directory.CreateDirectory(_currentDirM3U);
                    Directory.CreateDirectory(_currentDirM3U+ "\\Best");
                }
                Thread.Sleep(500);
                File.WriteAllLines(_currentDirM3U + "\\" + bestStreams + newIp + ".m3u", template);
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.Message);
            }
        }

        public Tuple<List<string>,List<string[]>> ScanDirectory()
        {
            try
            {
                var dialog = new FolderBrowserDialog();
                var fileList = new List<string[]>();
                dialog.RootFolder = Environment.SpecialFolder.MyComputer;
                var result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    DirectoryPath = dialog.SelectedPath;
                    _form.Video.DirectoryPath = DirectoryPath;
                    _form.Text = @"Enigma2 Tester     " + @"You choose : " + DirectoryPath;
                    var filePathesList = Directory.GetFiles(DirectoryPath, @"*.m3u").ToList();
                    var subDirectories = Directory.GetDirectories(DirectoryPath);
                    _form.AddToLog("Looking for m3u files in directories...");
                    _form.AddToLog(filePathesList.Select(n => n).ToList());
                    if (subDirectories.Length > 0)
                    {
                        foreach (var subDirectory in subDirectories)
                        {
                            var filesInSubdirectory = Directory.GetFiles(subDirectory, @"*.m3u");
                            filePathesList.AddRange(filesInSubdirectory);
                            _form.AddToLog(filePathesList.Select(n => n).ToList());
                        }
                    }
                    _form.AddToLog("Search end!");
                    _form.AddToLog("Loading content from m3u files. It may take few seconds!");
                    MessageBox.Show("Now we trying to load yours files! \n\nBe patient!",@"Info");
                    fileList.AddRange(filePathesList.Select(n => File.ReadAllLines(n, Encoding.Default)));
                    if (fileList.Count == 0)
                    {
                        MessageBox.Show(@"No files!", @"Error!");
                        return null;
                    }
                    MessageBox.Show("Loading Complete!\n\nLoaded: " + fileList.Count + " files",@"Info");
                    return Tuple.Create(filePathesList,fileList);
                }

                if(result != DialogResult.Cancel)
                {
                    DirectoryPath = Directory.GetCurrentDirectory();
                    _form.Video.DirectoryPath = DirectoryPath;
                    MessageBox.Show(
                        @"Cannot open dialog box! Directory choosen to: " + DirectoryPath,
                        @"Error");
                    _form.Text = @"Enigma2 Tester     " + @"You choose : " + DirectoryPath;
                    var filePathesList = Directory.GetFiles(DirectoryPath, @"*.m3u").ToList();
                    Parallel.Invoke(() => fileList.AddRange(filePathesList.Select(n => File.ReadAllLines(n, Encoding.Default))));
                    return Tuple.Create(filePathesList, fileList);
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(@"You have not selected a folder." + ec, @"Błąd");
                _form.AddLogToFile(ec.Message);
            }
            return null;
        }

        public string FirstLineHttp(string[] fileContent)
        {
            var lineWithIp = string.Empty;
            try
            {
                lineWithIp = (from line in fileContent where line.StartsWith("http://") select new Uri(line) into myUri select Dns.GetHostAddresses(myUri.Host)[0].ToString()).FirstOrDefault();
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.Message);
            }
            return lineWithIp == string.Empty ? null : lineWithIp;
        }

        public void RemoveTemp(string directory)
        {
            try
            {
                var tempDirectoryRemove = directory + "\\temp";
                var di = new DirectoryInfo(tempDirectoryRemove);
                if (!di.Exists) return;
                foreach (var file in di.GetFiles())
                {
                    file.Delete();
                }
                foreach (var dir in di.GetDirectories())
                {
                    dir.Delete(true);
                }
                if (Directory.GetFiles(tempDirectoryRemove).Length == 0)
                {
                    Directory.Delete(tempDirectoryRemove);
                }
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.Message);
            }
        }

        public void OpenOutputDirectory()
        {
            Process.Start(_currentDirM3U);
        }
    }
}
