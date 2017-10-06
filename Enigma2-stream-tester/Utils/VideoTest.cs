using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using MediaInfoDotNet;

namespace Enigma2_stream_tester.Utils
{
    public class VideoTest
    {
        public string DirectoryPath;
        private FileOperations _operation;

        private readonly Main _form;

        public VideoTest(Main form)
        {
            _form = form;
        }

        public void Check(string ip, string port, string channel)
        {
            try
            {
                _operation = _form.Operation;
                var timeout = _form.ConfigurationItems[0].timeout;
                var outputDirectory = DirectoryPath + "\\temp\\"; //zrobic z konfigu
                var outputFile = outputDirectory + ip + ".mpeg";
                if (!Directory.Exists(outputDirectory))
                {
                    var di = Directory.CreateDirectory(outputDirectory);
                    di.Attributes = FileAttributes.Directory | FileAttributes.Hidden;
                }
                using (var httpClient = new WebClient())
                {
                    httpClient.DownloadFileAsync(new Uri("http://" + ip + ":" + port + channel), outputFile);
                    Thread.Sleep(timeout);
                    httpClient.CancelAsync();
                }
                
                var infoTuple = Info(outputFile);
                var frameCount = infoTuple.Item1;
                var resolution = infoTuple.Item2;
                if (frameCount > timeout / 1000 * 16) // Need to develop a way of estimating the quality of the source
                {
                    _operation.NewM3U(ip, port, true, resolution); //save as best m3u
                }
                if (frameCount > 2)
                {
                    _operation.NewM3U(ip, port, false, resolution); //save as new m3u
                }
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.ToString());
            }
        }

        public Tuple<int, string> Info(string path) //path = mpeg file path
        {
            try
            {
                var media = new MediaFile(path);
                var f = new FileInfo(path);
                var videoFile = media.Video;
                if (videoFile.Count < 1) return Tuple.Create(0, string.Empty);
                var codecType = videoFile[0].InternetMediaType;
                var videoHeight = videoFile[0].Height;
                var videoWidth = videoFile[0].Width;
                var fileLength = f.Length;
                var frameCount = videoFile[0].frameCount;
                //log
                _form.AddToLog(path);
                _form.AddToLog("Codec : " + codecType);
                _form.AddToLog("Resolution : " + videoWidth + "x" + videoHeight);
                _form.AddToLog("File length : " + fileLength);
                _form.AddToLog("Frames captured : " + frameCount);
                return Tuple.Create(frameCount, videoHeight.ToString());
            }
            catch (Exception e)
            {
                _form.AddLogToFile(e.ToString());
                return Tuple.Create(0, string.Empty);
            }
        }
    }
}
