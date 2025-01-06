using System.Resources;

namespace SetFileDate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Set the minimum allowable value on the DateTimePicker controls to one day more
            // than the actual minimum value that the control will accept. This will allow us
            // to use the real minimum value as a flag that indicates that the corresponding
            // file date value should not be changed. For example, if the file creation date
            // should not be changed, the real minimum value for the DateTimePicker will be 
            // passed to the date setting function. If the file creation date should be changed,
            // the actual user-selected value on the DateTimePicker control will be passed 
            // to the function.
            this.creationDatePicker.MinDate = DateTimePicker.MinimumDateTime.AddDays(1);
            this.accessedDatePicker.MinDate = DateTimePicker.MinimumDateTime.AddDays(1);
            this.modifiedDatePicker.MinDate = DateTimePicker.MinimumDateTime.AddDays(1);
        }

        /// <summary>
        /// Sets the enabled state of the Set Dates button based on whether at least
        /// one date checkbox is checked.
        /// </summary>
        private void SetButtonEnabledState()
        {
            this.setDatesButton.Enabled = this.accessedCheckBox.Checked | this.creationCheckBox.Checked | this.modifiedCheckBox.Checked;
        }

        private void CreationCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.SetButtonEnabledState();
            creationDatePicker.Enabled = creationTimePicker.Enabled = creationCheckBox.Checked;
        }

        private void AccessedCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.SetButtonEnabledState();
            accessedDatePicker.Enabled = accessedTimePicker.Enabled = accessedCheckBox.Checked;
        }

        private void ModifiedCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            this.SetButtonEnabledState();
            modifiedDatePicker.Enabled = modifiedTimePicker.Enabled = modifiedCheckBox.Checked;
        }

        private void SetDatesButtonClick(object sender, EventArgs e)
        {
            // Set the file dates on the specified folder.
            SetDates(this.folderPathTextBox.Text, this.subFoldersCheckBox.Checked, this.readOnlyCheckBox.Checked, this.SelectedCreationTime, this.SelectedAccessedTime, this.SelectedModifiedTime);

            // Display a message that the operation has completed.
            MessageBox.Show("File date setting completed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        /* Set file dates based on the latest file time.
            DateTime latestModifiedDate = GetLatestDate(this.textFolderPath.Text, this.checkSubfolders.Checked);

            // Set the file dates on the specified folder.
            this.SetDates(this.textFolderPath.Text, this.checkSubfolders.Checked, this.checkReadOnly.Checked, latestModifiedDate);

            // Display a message that the operation has completed.
            MessageBox.Show("File date setting completed.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        */


        /// <summary>
        /// Gets a DateTime object indicating the new creation date/time that the user has selected.
        /// </summary>
        /// <remarks>Returns DateTimePicker.MinimumDateTime if the corresponding check box is unchecked.</remarks>
        private DateTime SelectedCreationTime
        {
            get
            {
                if (this.creationCheckBox.Checked)
                {
                    DateTime selectedValue = new(this.creationDatePicker.Value.Date.Year, this.creationDatePicker.Value.Date.Month, this.creationDatePicker.Value.Date.Day, this.creationTimePicker.Value.TimeOfDay.Hours, this.creationTimePicker.Value.TimeOfDay.Minutes, this.creationTimePicker.Value.TimeOfDay.Seconds);
                    return selectedValue;
                }
                else
                {
                    return DateTimePicker.MinimumDateTime;
                }
            }
        }

        /// <summary>
        /// Gets a DateTime object indicating the new last modification date/time that the user has selected.
        /// </summary>
        /// <remarks>Returns DateTimePicker.MinimumDateTime if the corresponding check box is unchecked.</remarks>
        private DateTime SelectedModifiedTime
        {
            get
            {
                if (this.modifiedCheckBox.Checked)
                {
                    DateTime selectedValue = new (this.modifiedDatePicker.Value.Date.Year, this.modifiedDatePicker.Value.Date.Month, this.modifiedDatePicker.Value.Date.Day, this.modifiedTimePicker.Value.TimeOfDay.Hours, this.modifiedTimePicker.Value.TimeOfDay.Minutes, this.modifiedTimePicker.Value.TimeOfDay.Seconds);
                    return selectedValue;
                }
                else
                {
                    return DateTimePicker.MinimumDateTime;
                }
            }
        }

        /// <summary>
        /// Gets a DateTime object indicating the new last accessed date/time that the user has selected.
        /// </summary>
        /// <remarks>Returns DateTimePicker.MinimumDateTime if the corresponding check box is unchecked.</remarks>
        private DateTime SelectedAccessedTime
        {
            get
            {
                if (this.accessedCheckBox.Checked)
                {
                    DateTime selectedValue = new (this.accessedDatePicker.Value.Date.Year, this.accessedDatePicker.Value.Date.Month, this.accessedDatePicker.Value.Date.Day, this.accessedTimePicker.Value.TimeOfDay.Hours, this.accessedTimePicker.Value.TimeOfDay.Minutes, this.accessedTimePicker.Value.TimeOfDay.Seconds);
                    return selectedValue;
                }
                else
                {
                    return DateTimePicker.MinimumDateTime;
                }
            }
        }

        /*
        private DateTime GetLatestDate(string path, bool recursive)
        {
            DateTime returnValue = DateTime.MinValue;

            // If the specified directory path exists, perform the date setting operation(s).
            if (Directory.Exists(path))
            {
                // Get a DirectoryInfo object representing the specified folder.
                DirectoryInfo di = new DirectoryInfo(path);

                // If the operation is recursive, process the subfolders of the specified folder.
                if (recursive)
                {
                    DirectoryInfo[] subDirInfos = di.GetDirectories();
                    foreach (DirectoryInfo subDi in subDirInfos)
                    {
                        DateTime maxSubFolderDate = this.GetLatestDate(subDi.FullName, recursive);
                        if (maxSubFolderDate > returnValue)
                        {
                            returnValue = maxSubFolderDate;
                        }
                    }
                }

                // Get an array of FileInfo objects for the files in the specified directory.
                FileInfo[] fileInfos = di.GetFiles();

                // Process each file in the array.
                foreach (FileInfo fi in fileInfos)
                {
                    if (fi.LastWriteTime > returnValue)
                    {
                        returnValue = fi.LastWriteTime;
                    }
                }
            }
            return returnValue;
        }
        */

        /// <summary>
        /// Sets the dates on the files in the specified folder.
        /// </summary>
        /// <param name="path">the path of the folder whose files need to have their dates set</param>
        /// <param name="recursive">Whether the operation should be performed on subfolders.</param>
        /// <param name="includeReadOnly">Whether to include read-only files in the processing.</param>
        /// <param name="creationTime">the desired creation date/time to set on all files</param>
        /// <param name="accessedTime">the desired accessed date/time to set on all files</param>
        /// <param name="modifiedTime">the desired modified date/time to set on all files</param>
        private static void SetDates(string path, bool recursive, bool includeReadOnly, DateTime creationTime, DateTime accessedTime, DateTime modifiedTime)
        {
            // If the specified directory path exists, perform the date setting operation(s).
            if (Directory.Exists(path))
            {
                // Get a DirectoryInfo object representing the specified folder.
                DirectoryInfo di = new (path);

                // If the operation is recursive, process the subfolders of the specified folder.
                if (recursive)
                {
                    DirectoryInfo[] subDirInfos = di.GetDirectories();
                    foreach (DirectoryInfo subDi in subDirInfos)
                    {
                        SetDates(subDi.FullName, recursive, includeReadOnly, creationTime, accessedTime, modifiedTime);
                    }
                }

                // Get an array of FileInfo objects for the files in the specified directory.
                FileInfo[] fileInfos = di.GetFiles();

                // Process each file in the array.
                foreach (FileInfo fi in fileInfos)
                {
                    ResetDates(fi, includeReadOnly, creationTime, modifiedTime, accessedTime);
                }

                ResetDates(di, includeReadOnly, creationTime, modifiedTime, accessedTime);
            }
        }

        /// <summary>
        /// Set the dates on the specified directory.
        /// </summary>
        /// <param name="fileSysInfo">The file system object whose dates are to be set.</param>
        /// <param name="processIfReadOnly">Whether to process read-only file system objects.</param>
        /// <param name="creationTime">The creation date/time to set for each file.</param>
        /// <param name="modifiedTime">The last-modified date/time to set for each file.</param>
        /// <param name="accessedTime">The last-accessed date/time to set for each file.</param>
        private static void ResetDates(FileSystemInfo fileSysInfo, bool processIfReadOnly, DateTime creationTime, DateTime modifiedTime, DateTime accessedTime)
        {
            bool attributesAltered = false;

            FileAttributes originalAttributes = fileSysInfo.Attributes;

            if (((fileSysInfo.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly) && processIfReadOnly)
            {
                // TODO: Why set this to directory? Shouldn't we just turn off the read-only attribute?
                fileSysInfo.Attributes = FileAttributes.Directory;
                attributesAltered = true;
            }

            if (DateTimePicker.MinimumDateTime != creationTime)
            {
                fileSysInfo.CreationTime = creationTime;
            }

            if (DateTimePicker.MinimumDateTime != modifiedTime)
            {
                fileSysInfo.LastWriteTime = modifiedTime;
            }

            if (DateTimePicker.MinimumDateTime != accessedTime)
            {
                fileSysInfo.LastAccessTime = accessedTime;
            }

            if (attributesAltered)
            {
                fileSysInfo.Attributes = originalAttributes;
            }
        }

        private void PathBrowseButtonClick(object sender, EventArgs e)
        {
            // Create a new FolderBrowserDialog object.
            FolderBrowserDialog fbd = new()
            {
                Description = "Select the folder for which you want to set file dates.",

                // Set the default folder of the dialog to the logical Desktop (not the user's actual Desktop folder).
                RootFolder = Environment.SpecialFolder.Desktop
            };

            // If the folder path currently in the text box exists, make that the default
            // selected folder for the browser dialog.
            if (Directory.Exists(this.folderPathTextBox.Text))
            {
                fbd.SelectedPath = this.folderPathTextBox.Text;
            }

            // Show the dialog. If the user clicks OK, set the text box value to the
            // path that was selected in the dialog.
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                this.folderPathTextBox.Text = fbd.SelectedPath;
            }
        }

        private void FolderPathLabelClick(object sender, EventArgs e)
        {
            // Set the focus to the folder path text box.
            this.folderPathTextBox.Focus();
        }
    }
}
