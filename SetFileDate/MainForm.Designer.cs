namespace SetFileDate
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            folderPathTextBox = new TextBox();
            pathBrowseButton = new Button();
            subFoldersCheckBox = new CheckBox();
            readOnlyCheckBox = new CheckBox();
            creationCheckBox = new CheckBox();
            accessedCheckBox = new CheckBox();
            modifiedCheckBox = new CheckBox();
            creationDatePicker = new DateTimePicker();
            accessedDatePicker = new DateTimePicker();
            modifiedDatePicker = new DateTimePicker();
            setDatesButton = new Button();
            folderPathLabel = new Label();
            creationTimePicker = new DateTimePicker();
            accessedTimePicker = new DateTimePicker();
            modifiedTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            folderPathTextBox.AutoCompleteSource = AutoCompleteSource.FileSystemDirectories;
            folderPathTextBox.Location = new Point(12, 37);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(584, 31);
            folderPathTextBox.TabIndex = 1;
            // 
            // pathBrowseButton
            // 
            pathBrowseButton.Location = new Point(602, 30);
            pathBrowseButton.Name = "pathBrowseButton";
            pathBrowseButton.Size = new Size(120, 45);
            pathBrowseButton.TabIndex = 2;
            pathBrowseButton.Text = "&Browse...";
            pathBrowseButton.UseVisualStyleBackColor = true;
            pathBrowseButton.Click += PathBrowseButtonClick;
            // 
            // subFoldersCheckBox
            // 
            subFoldersCheckBox.AutoSize = true;
            subFoldersCheckBox.Location = new Point(12, 74);
            subFoldersCheckBox.Name = "subFoldersCheckBox";
            subFoldersCheckBox.Size = new Size(186, 29);
            subFoldersCheckBox.TabIndex = 3;
            subFoldersCheckBox.Text = "Include S&ubfolders";
            subFoldersCheckBox.UseVisualStyleBackColor = true;
            // 
            // readOnlyCheckBox
            // 
            readOnlyCheckBox.AutoSize = true;
            readOnlyCheckBox.Location = new Point(12, 109);
            readOnlyCheckBox.Name = "readOnlyCheckBox";
            readOnlyCheckBox.Size = new Size(222, 29);
            readOnlyCheckBox.TabIndex = 4;
            readOnlyCheckBox.Text = "Include &Read-Only Files";
            readOnlyCheckBox.UseVisualStyleBackColor = true;
            // 
            // creationCheckBox
            // 
            creationCheckBox.AutoSize = true;
            creationCheckBox.Location = new Point(12, 163);
            creationCheckBox.Name = "creationCheckBox";
            creationCheckBox.Size = new Size(176, 29);
            creationCheckBox.TabIndex = 5;
            creationCheckBox.Text = "Set &Creation Date";
            creationCheckBox.UseVisualStyleBackColor = true;
            creationCheckBox.CheckedChanged += CreationCheckBoxCheckedChanged;
            // 
            // accessedCheckBox
            // 
            accessedCheckBox.AutoSize = true;
            accessedCheckBox.Location = new Point(12, 202);
            accessedCheckBox.Name = "accessedCheckBox";
            accessedCheckBox.Size = new Size(219, 29);
            accessedCheckBox.TabIndex = 8;
            accessedCheckBox.Text = "Set Last &Accessed Date";
            accessedCheckBox.UseVisualStyleBackColor = true;
            accessedCheckBox.CheckedChanged += AccessedCheckBoxCheckedChanged;
            // 
            // modifiedCheckBox
            // 
            modifiedCheckBox.AutoSize = true;
            modifiedCheckBox.Location = new Point(12, 241);
            modifiedCheckBox.Name = "modifiedCheckBox";
            modifiedCheckBox.Size = new Size(218, 29);
            modifiedCheckBox.TabIndex = 11;
            modifiedCheckBox.Text = "Set Last &Modified Date";
            modifiedCheckBox.UseVisualStyleBackColor = true;
            modifiedCheckBox.CheckedChanged += ModifiedCheckBoxCheckedChanged;
            // 
            // creationDatePicker
            // 
            creationDatePicker.Enabled = false;
            creationDatePicker.Location = new Point(256, 162);
            creationDatePicker.Name = "creationDatePicker";
            creationDatePicker.Size = new Size(300, 31);
            creationDatePicker.TabIndex = 6;
            // 
            // accessedDatePicker
            // 
            accessedDatePicker.Enabled = false;
            accessedDatePicker.Location = new Point(256, 201);
            accessedDatePicker.Name = "accessedDatePicker";
            accessedDatePicker.Size = new Size(300, 31);
            accessedDatePicker.TabIndex = 9;
            // 
            // modifiedDatePicker
            // 
            modifiedDatePicker.Enabled = false;
            modifiedDatePicker.Location = new Point(256, 240);
            modifiedDatePicker.Name = "modifiedDatePicker";
            modifiedDatePicker.Size = new Size(300, 31);
            modifiedDatePicker.TabIndex = 12;
            // 
            // setDatesButton
            // 
            setDatesButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            setDatesButton.Enabled = false;
            setDatesButton.Location = new Point(604, 294);
            setDatesButton.Name = "setDatesButton";
            setDatesButton.Size = new Size(120, 45);
            setDatesButton.TabIndex = 14;
            setDatesButton.Text = "&Set Dates";
            setDatesButton.UseVisualStyleBackColor = true;
            setDatesButton.Click += SetDatesButtonClick;
            // 
            // folderPathLabel
            // 
            folderPathLabel.AutoSize = true;
            folderPathLabel.Location = new Point(12, 9);
            folderPathLabel.Name = "folderPathLabel";
            folderPathLabel.Size = new Size(101, 25);
            folderPathLabel.TabIndex = 0;
            folderPathLabel.Text = "Folder Path";
            folderPathLabel.Click += FolderPathLabelClick;
            // 
            // creationTimePicker
            // 
            creationTimePicker.Enabled = false;
            creationTimePicker.Format = DateTimePickerFormat.Time;
            creationTimePicker.Location = new Point(562, 162);
            creationTimePicker.Name = "creationTimePicker";
            creationTimePicker.ShowUpDown = true;
            creationTimePicker.Size = new Size(150, 31);
            creationTimePicker.TabIndex = 7;
            // 
            // accessedTimePicker
            // 
            accessedTimePicker.Enabled = false;
            accessedTimePicker.Format = DateTimePickerFormat.Time;
            accessedTimePicker.Location = new Point(562, 201);
            accessedTimePicker.Name = "accessedTimePicker";
            accessedTimePicker.ShowUpDown = true;
            accessedTimePicker.Size = new Size(150, 31);
            accessedTimePicker.TabIndex = 10;
            // 
            // modifiedTimePicker
            // 
            modifiedTimePicker.Enabled = false;
            modifiedTimePicker.Format = DateTimePickerFormat.Time;
            modifiedTimePicker.Location = new Point(562, 240);
            modifiedTimePicker.Name = "modifiedTimePicker";
            modifiedTimePicker.ShowUpDown = true;
            modifiedTimePicker.Size = new Size(150, 31);
            modifiedTimePicker.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 351);
            Controls.Add(modifiedTimePicker);
            Controls.Add(accessedTimePicker);
            Controls.Add(creationTimePicker);
            Controls.Add(folderPathLabel);
            Controls.Add(setDatesButton);
            Controls.Add(modifiedDatePicker);
            Controls.Add(accessedDatePicker);
            Controls.Add(creationDatePicker);
            Controls.Add(modifiedCheckBox);
            Controls.Add(accessedCheckBox);
            Controls.Add(creationCheckBox);
            Controls.Add(readOnlyCheckBox);
            Controls.Add(subFoldersCheckBox);
            Controls.Add(pathBrowseButton);
            Controls.Add(folderPathTextBox);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "Set File Dates";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox folderPathTextBox;
        private Button pathBrowseButton;
        private CheckBox subFoldersCheckBox;
        private CheckBox readOnlyCheckBox;
        private CheckBox creationCheckBox;
        private CheckBox accessedCheckBox;
        private CheckBox modifiedCheckBox;
        private DateTimePicker creationDatePicker;
        private DateTimePicker accessedDatePicker;
        private DateTimePicker modifiedDatePicker;
        private Button setDatesButton;
        private Label folderPathLabel;
        private DateTimePicker creationTimePicker;
        private DateTimePicker accessedTimePicker;
        private DateTimePicker modifiedTimePicker;
    }
}
