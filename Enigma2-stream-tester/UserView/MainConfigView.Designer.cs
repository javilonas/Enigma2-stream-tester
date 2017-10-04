namespace Enigma2_stream_tester.UserView
{
    partial class MainConfigView
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cfgChannels_comboBox = new System.Windows.Forms.ComboBox();
            this.cfgLists_comboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Port8002_Checkbox = new System.Windows.Forms.CheckBox();
            this.Port8001_Checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Speed_Value = new System.Windows.Forms.Label();
            this.Timeout_Value = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Speed_Trackbar = new System.Windows.Forms.TrackBar();
            this.Timeout_Trackbar = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout_Trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cfgChannels_comboBox);
            this.groupBox1.Controls.Add(this.cfgLists_comboBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(223, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Channels Select";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "Channel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(96, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "*All of them must be selected";
            // 
            // cfgChannels_comboBox
            // 
            this.cfgChannels_comboBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgChannels_comboBox.FormattingEnabled = true;
            this.cfgChannels_comboBox.Location = new System.Drawing.Point(6, 136);
            this.cfgChannels_comboBox.Name = "cfgChannels_comboBox";
            this.cfgChannels_comboBox.Size = new System.Drawing.Size(211, 24);
            this.cfgChannels_comboBox.TabIndex = 1;
            this.cfgChannels_comboBox.SelectedIndexChanged += new System.EventHandler(this.Channel_IndexChanged);
            // 
            // cfgLists_comboBox
            // 
            this.cfgLists_comboBox.Font = new System.Drawing.Font("Berlin Sans FB", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cfgLists_comboBox.FormattingEnabled = true;
            this.cfgLists_comboBox.Location = new System.Drawing.Point(49, 60);
            this.cfgLists_comboBox.Name = "cfgLists_comboBox";
            this.cfgLists_comboBox.Size = new System.Drawing.Size(121, 23);
            this.cfgLists_comboBox.TabIndex = 0;
            this.cfgLists_comboBox.SelectedIndexChanged += new System.EventHandler(this.List_IndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Port8002_Checkbox);
            this.groupBox2.Controls.Add(this.Port8001_Checkbox);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(232, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 209);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ports";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "*You can select only one!";
            // 
            // Port8002_Checkbox
            // 
            this.Port8002_Checkbox.AutoSize = true;
            this.Port8002_Checkbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port8002_Checkbox.Location = new System.Drawing.Point(47, 123);
            this.Port8002_Checkbox.Name = "Port8002_Checkbox";
            this.Port8002_Checkbox.Size = new System.Drawing.Size(109, 25);
            this.Port8002_Checkbox.TabIndex = 1;
            this.Port8002_Checkbox.Text = "Port 8002";
            this.Port8002_Checkbox.UseVisualStyleBackColor = true;
            this.Port8002_Checkbox.CheckStateChanged += new System.EventHandler(this.Port8002_CheckChanged);
            // 
            // Port8001_Checkbox
            // 
            this.Port8001_Checkbox.AutoSize = true;
            this.Port8001_Checkbox.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port8001_Checkbox.Location = new System.Drawing.Point(47, 60);
            this.Port8001_Checkbox.Name = "Port8001_Checkbox";
            this.Port8001_Checkbox.Size = new System.Drawing.Size(105, 25);
            this.Port8001_Checkbox.TabIndex = 0;
            this.Port8001_Checkbox.Text = "Port 8001";
            this.Port8001_Checkbox.UseVisualStyleBackColor = true;
            this.Port8001_Checkbox.CheckStateChanged += new System.EventHandler(this.Port8001_CheckChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Speed_Value);
            this.groupBox3.Controls.Add(this.Timeout_Value);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.Speed_Trackbar);
            this.groupBox3.Controls.Add(this.Timeout_Trackbar);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(463, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 209);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Others";
            // 
            // Speed_Value
            // 
            this.Speed_Value.AutoSize = true;
            this.Speed_Value.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_Value.Location = new System.Drawing.Point(183, 112);
            this.Speed_Value.Name = "Speed_Value";
            this.Speed_Value.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Speed_Value.Size = new System.Drawing.Size(0, 21);
            this.Speed_Value.TabIndex = 6;
            // 
            // Timeout_Value
            // 
            this.Timeout_Value.AutoSize = true;
            this.Timeout_Value.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timeout_Value.Location = new System.Drawing.Point(157, 36);
            this.Timeout_Value.Name = "Timeout_Value";
            this.Timeout_Value.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Timeout_Value.Size = new System.Drawing.Size(0, 21);
            this.Timeout_Value.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "*Recommended speed value = 20";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Speed of check";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Timeout";
            // 
            // Speed_Trackbar
            // 
            this.Speed_Trackbar.Location = new System.Drawing.Point(6, 136);
            this.Speed_Trackbar.Maximum = 40;
            this.Speed_Trackbar.Name = "Speed_Trackbar";
            this.Speed_Trackbar.Size = new System.Drawing.Size(211, 45);
            this.Speed_Trackbar.TabIndex = 1;
            this.Speed_Trackbar.Value = 20;
            this.Speed_Trackbar.ValueChanged += new System.EventHandler(this.Speed_ValueChanged);
            // 
            // Timeout_Trackbar
            // 
            this.Timeout_Trackbar.LargeChange = 5000;
            this.Timeout_Trackbar.Location = new System.Drawing.Point(6, 60);
            this.Timeout_Trackbar.Maximum = 20000;
            this.Timeout_Trackbar.Minimum = 1000;
            this.Timeout_Trackbar.Name = "Timeout_Trackbar";
            this.Timeout_Trackbar.Size = new System.Drawing.Size(211, 45);
            this.Timeout_Trackbar.SmallChange = 1000;
            this.Timeout_Trackbar.TabIndex = 0;
            this.Timeout_Trackbar.TickFrequency = 1000;
            this.Timeout_Trackbar.Value = 10000;
            this.Timeout_Trackbar.ValueChanged += new System.EventHandler(this.TimeoutValue_Changed);
            // 
            // MainConfigView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainConfigView";
            this.Size = new System.Drawing.Size(686, 215);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Speed_Trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Timeout_Trackbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Speed_Value;
        private System.Windows.Forms.Label Timeout_Value;
        public System.Windows.Forms.ComboBox cfgChannels_comboBox;
        public System.Windows.Forms.ComboBox cfgLists_comboBox;
        public System.Windows.Forms.CheckBox Port8002_Checkbox;
        public System.Windows.Forms.CheckBox Port8001_Checkbox;
        public System.Windows.Forms.TrackBar Speed_Trackbar;
        public System.Windows.Forms.TrackBar Timeout_Trackbar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}
