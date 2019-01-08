namespace Detector
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdDetectVM = new System.Windows.Forms.Button();
            this.lblDetectVM = new System.Windows.Forms.Label();
            this.cmdIsDebuggerAttached = new System.Windows.Forms.Button();
            this.lblIsDebugger = new System.Windows.Forms.Label();
            this.cmdListProcesses = new System.Windows.Forms.Button();
            this.lstProcesses = new System.Windows.Forms.ListBox();
            this.cmdAccessRights = new System.Windows.Forms.Button();
            this.cmdDetectRegistryKey = new System.Windows.Forms.Button();
            this.cmdDetectDrives = new System.Windows.Forms.Button();
            this.lblDetectRegistryKey = new System.Windows.Forms.Label();
            this.lblDetectDrives = new System.Windows.Forms.Label();
            this.cmdSystemDriveSize = new System.Windows.Forms.Button();
            this.lblSystemDriveSize = new System.Windows.Forms.Label();
            this.cmdDetectBIOSSerialNumber = new System.Windows.Forms.Button();
            this.lblDetectBIOSSerialNumber = new System.Windows.Forms.Label();
            this.cmdDetectSystemModel = new System.Windows.Forms.Button();
            this.lblDetectSystemModel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdDetectVM
            // 
            this.cmdDetectVM.Location = new System.Drawing.Point(12, 12);
            this.cmdDetectVM.Name = "cmdDetectVM";
            this.cmdDetectVM.Size = new System.Drawing.Size(123, 23);
            this.cmdDetectVM.TabIndex = 0;
            this.cmdDetectVM.Text = "Detect VM";
            this.cmdDetectVM.UseVisualStyleBackColor = true;
            this.cmdDetectVM.Click += new System.EventHandler(this.cmdDetectVM_Click);
            // 
            // lblDetectVM
            // 
            this.lblDetectVM.AutoSize = true;
            this.lblDetectVM.Location = new System.Drawing.Point(143, 17);
            this.lblDetectVM.Name = "lblDetectVM";
            this.lblDetectVM.Size = new System.Drawing.Size(87, 13);
            this.lblDetectVM.TabIndex = 1;
            this.lblDetectVM.Text = "No VM Detected";
            // 
            // cmdIsDebuggerAttached
            // 
            this.cmdIsDebuggerAttached.Location = new System.Drawing.Point(12, 41);
            this.cmdIsDebuggerAttached.Name = "cmdIsDebuggerAttached";
            this.cmdIsDebuggerAttached.Size = new System.Drawing.Size(123, 23);
            this.cmdIsDebuggerAttached.TabIndex = 2;
            this.cmdIsDebuggerAttached.Text = "Is Debugger Attached";
            this.cmdIsDebuggerAttached.UseVisualStyleBackColor = true;
            this.cmdIsDebuggerAttached.Click += new System.EventHandler(this.cmdIsDebuggerAttached_Click);
            // 
            // lblIsDebugger
            // 
            this.lblIsDebugger.AutoSize = true;
            this.lblIsDebugger.Location = new System.Drawing.Point(143, 46);
            this.lblIsDebugger.Name = "lblIsDebugger";
            this.lblIsDebugger.Size = new System.Drawing.Size(118, 13);
            this.lblIsDebugger.TabIndex = 3;
            this.lblIsDebugger.Text = "No Debugger Detected";
            // 
            // cmdListProcesses
            // 
            this.cmdListProcesses.Location = new System.Drawing.Point(12, 215);
            this.cmdListProcesses.Name = "cmdListProcesses";
            this.cmdListProcesses.Size = new System.Drawing.Size(123, 23);
            this.cmdListProcesses.TabIndex = 4;
            this.cmdListProcesses.Text = "List Processes";
            this.cmdListProcesses.UseVisualStyleBackColor = true;
            this.cmdListProcesses.Click += new System.EventHandler(this.cmdListProcesses_Click);
            // 
            // lstProcesses
            // 
            this.lstProcesses.FormattingEnabled = true;
            this.lstProcesses.Location = new System.Drawing.Point(146, 215);
            this.lstProcesses.Name = "lstProcesses";
            this.lstProcesses.Size = new System.Drawing.Size(225, 186);
            this.lstProcesses.TabIndex = 5;
            // 
            // cmdAccessRights
            // 
            this.cmdAccessRights.Location = new System.Drawing.Point(12, 244);
            this.cmdAccessRights.Name = "cmdAccessRights";
            this.cmdAccessRights.Size = new System.Drawing.Size(123, 23);
            this.cmdAccessRights.TabIndex = 6;
            this.cmdAccessRights.Text = "Access Rights";
            this.cmdAccessRights.UseVisualStyleBackColor = true;
            this.cmdAccessRights.Click += new System.EventHandler(this.cmdAccessRights_Click);
            // 
            // cmdDetectRegistryKey
            // 
            this.cmdDetectRegistryKey.Location = new System.Drawing.Point(12, 70);
            this.cmdDetectRegistryKey.Name = "cmdDetectRegistryKey";
            this.cmdDetectRegistryKey.Size = new System.Drawing.Size(123, 23);
            this.cmdDetectRegistryKey.TabIndex = 7;
            this.cmdDetectRegistryKey.Text = "Detect Registry Key";
            this.cmdDetectRegistryKey.UseVisualStyleBackColor = true;
            this.cmdDetectRegistryKey.Click += new System.EventHandler(this.cmdDetectRegistryKey_Click);
            // 
            // cmdDetectDrives
            // 
            this.cmdDetectDrives.Location = new System.Drawing.Point(12, 99);
            this.cmdDetectDrives.Name = "cmdDetectDrives";
            this.cmdDetectDrives.Size = new System.Drawing.Size(123, 23);
            this.cmdDetectDrives.TabIndex = 8;
            this.cmdDetectDrives.Text = "Detect Drive(s)";
            this.cmdDetectDrives.UseVisualStyleBackColor = true;
            this.cmdDetectDrives.Click += new System.EventHandler(this.cmdDetectDrives_Click);
            // 
            // lblDetectRegistryKey
            // 
            this.lblDetectRegistryKey.AutoSize = true;
            this.lblDetectRegistryKey.Location = new System.Drawing.Point(143, 75);
            this.lblDetectRegistryKey.Name = "lblDetectRegistryKey";
            this.lblDetectRegistryKey.Size = new System.Drawing.Size(130, 13);
            this.lblDetectRegistryKey.TabIndex = 9;
            this.lblDetectRegistryKey.Text = "No Registry Key Detected";
            // 
            // lblDetectDrives
            // 
            this.lblDetectDrives.AutoSize = true;
            this.lblDetectDrives.Location = new System.Drawing.Point(143, 104);
            this.lblDetectDrives.Name = "lblDetectDrives";
            this.lblDetectDrives.Size = new System.Drawing.Size(107, 13);
            this.lblDetectDrives.TabIndex = 10;
            this.lblDetectDrives.Text = "No Drive(s) Detected";
            // 
            // cmdSystemDriveSize
            // 
            this.cmdSystemDriveSize.Location = new System.Drawing.Point(12, 128);
            this.cmdSystemDriveSize.Name = "cmdSystemDriveSize";
            this.cmdSystemDriveSize.Size = new System.Drawing.Size(123, 23);
            this.cmdSystemDriveSize.TabIndex = 11;
            this.cmdSystemDriveSize.Text = "System Drive Size";
            this.cmdSystemDriveSize.UseVisualStyleBackColor = true;
            this.cmdSystemDriveSize.Click += new System.EventHandler(this.cmdSystemDriveSize_Click);
            // 
            // lblSystemDriveSize
            // 
            this.lblSystemDriveSize.AutoSize = true;
            this.lblSystemDriveSize.Location = new System.Drawing.Point(143, 133);
            this.lblSystemDriveSize.Name = "lblSystemDriveSize";
            this.lblSystemDriveSize.Size = new System.Drawing.Size(92, 13);
            this.lblSystemDriveSize.TabIndex = 12;
            this.lblSystemDriveSize.Text = "System Drive Size";
            // 
            // cmdDetectBIOSSerialNumber
            // 
            this.cmdDetectBIOSSerialNumber.Location = new System.Drawing.Point(12, 157);
            this.cmdDetectBIOSSerialNumber.Name = "cmdDetectBIOSSerialNumber";
            this.cmdDetectBIOSSerialNumber.Size = new System.Drawing.Size(123, 23);
            this.cmdDetectBIOSSerialNumber.TabIndex = 13;
            this.cmdDetectBIOSSerialNumber.Text = "Detect BIOS S/N";
            this.cmdDetectBIOSSerialNumber.UseVisualStyleBackColor = true;
            this.cmdDetectBIOSSerialNumber.Click += new System.EventHandler(this.cmdDetectBIOSSerialNumber_Click);
            // 
            // lblDetectBIOSSerialNumber
            // 
            this.lblDetectBIOSSerialNumber.AutoSize = true;
            this.lblDetectBIOSSerialNumber.Location = new System.Drawing.Point(143, 162);
            this.lblDetectBIOSSerialNumber.Name = "lblDetectBIOSSerialNumber";
            this.lblDetectBIOSSerialNumber.Size = new System.Drawing.Size(119, 13);
            this.lblDetectBIOSSerialNumber.TabIndex = 14;
            this.lblDetectBIOSSerialNumber.Text = "No BIOS S/N Detected";
            // 
            // cmdDetectSystemModel
            // 
            this.cmdDetectSystemModel.Location = new System.Drawing.Point(12, 186);
            this.cmdDetectSystemModel.Name = "cmdDetectSystemModel";
            this.cmdDetectSystemModel.Size = new System.Drawing.Size(123, 23);
            this.cmdDetectSystemModel.TabIndex = 15;
            this.cmdDetectSystemModel.Text = "Detect System Model";
            this.cmdDetectSystemModel.UseVisualStyleBackColor = true;
            this.cmdDetectSystemModel.Click += new System.EventHandler(this.cmdDetectSystemModel_Click);
            // 
            // lblDetectSystemModel
            // 
            this.lblDetectSystemModel.AutoSize = true;
            this.lblDetectSystemModel.Location = new System.Drawing.Point(143, 191);
            this.lblDetectSystemModel.Name = "lblDetectSystemModel";
            this.lblDetectSystemModel.Size = new System.Drawing.Size(90, 13);
            this.lblDetectSystemModel.TabIndex = 16;
            this.lblDetectSystemModel.Text = "No System Model";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 411);
            this.Controls.Add(this.lblDetectSystemModel);
            this.Controls.Add(this.cmdDetectSystemModel);
            this.Controls.Add(this.lblDetectBIOSSerialNumber);
            this.Controls.Add(this.cmdDetectBIOSSerialNumber);
            this.Controls.Add(this.lblSystemDriveSize);
            this.Controls.Add(this.cmdSystemDriveSize);
            this.Controls.Add(this.lblDetectDrives);
            this.Controls.Add(this.lblDetectRegistryKey);
            this.Controls.Add(this.cmdDetectDrives);
            this.Controls.Add(this.cmdDetectRegistryKey);
            this.Controls.Add(this.cmdAccessRights);
            this.Controls.Add(this.lstProcesses);
            this.Controls.Add(this.cmdListProcesses);
            this.Controls.Add(this.lblIsDebugger);
            this.Controls.Add(this.cmdIsDebuggerAttached);
            this.Controls.Add(this.lblDetectVM);
            this.Controls.Add(this.cmdDetectVM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Detector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdDetectVM;
        private System.Windows.Forms.Label lblDetectVM;
        private System.Windows.Forms.Button cmdIsDebuggerAttached;
        private System.Windows.Forms.Label lblIsDebugger;
        private System.Windows.Forms.Button cmdListProcesses;
        private System.Windows.Forms.ListBox lstProcesses;
        private System.Windows.Forms.Button cmdAccessRights;
        private System.Windows.Forms.Button cmdDetectRegistryKey;
        private System.Windows.Forms.Button cmdDetectDrives;
        private System.Windows.Forms.Label lblDetectRegistryKey;
        private System.Windows.Forms.Label lblDetectDrives;
        private System.Windows.Forms.Button cmdSystemDriveSize;
        private System.Windows.Forms.Label lblSystemDriveSize;
        private System.Windows.Forms.Button cmdDetectBIOSSerialNumber;
        private System.Windows.Forms.Label lblDetectBIOSSerialNumber;
        private System.Windows.Forms.Button cmdDetectSystemModel;
        private System.Windows.Forms.Label lblDetectSystemModel;
    }
}

