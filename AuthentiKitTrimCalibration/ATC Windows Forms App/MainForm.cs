﻿using AuthentiKitTrimCalibration.ViewModel;
using MappingManager.Common.Model;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ATC_Windows_Forms_App
{
    public partial class MainForm : Form
    {
        private MainViewModel _viewModel;

        private readonly string VERSION="experimental";

        public MainForm()
        {
            try
            {
                InitializeComponent();
                _viewModel = new MainViewModel();
                InitalSetup();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error on Startup",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _viewModel.LoadMappings();
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error loading app",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }


        private void btnAddMapping_Click(object sender, EventArgs e)
        {
            try
            {
                Debug.WriteLine("Adding New mapping");
                _viewModel.NewMapping();
                LoadFormData();
                lsbMappings.SelectedIndex = lsbMappings.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new mapping",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        private void btnRemoveMapping_Click(object sender, EventArgs e)
        {
            try
            {
                if (mappingBindingSource.Current is MappingViewModel mappingViewModel)
                {
                    _viewModel.RemoveMapping(mappingViewModel);
                }
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error removing mapping",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _viewModel.Stop();
        }

        private void LoadFormData()
        {
            // Initialise the BindingSource
            mappingBindingSource.DataSource = _viewModel.Mappings;

            // Mapping selection on the Left
            lsbMappings.DataSource = mappingBindingSource;
            lsbMappings.DisplayMember = "Name";


            var dataBindingsInitalised = (btnActivate.DataBindings.Count > 0) ||
                (btnDeactivate.DataBindings.Count > 0) ||
                (axisConfigControl.DataBindings.Count > 0) ||
                (tbName.DataBindings.Count > 0) ||
                (cbMappingType.DataBindings.Count > 0) ||
                (buttonConfigControl.DataBindings.Count > 0);
            if (dataBindingsInitalised)
            {
                mappingBindingSource.ResetBindings(false);
            }
            else
            {
                // Mapping Name
                tbName.DataBindings.Add("Text", mappingBindingSource, "Name");
                tbName.DataBindings.Add("Enabled", mappingBindingSource, "CanApply");

                // Mapping Type
                cbMappingType.DataSource = _viewModel.MappingTypes;
                cbMappingType.DisplayMember = "Name";
                cbMappingType.ValueMember = "Id";
                cbMappingType.DataBindings.Add("SelectedValue", mappingBindingSource, "TypeId");
                cbMappingType.DataBindings.Add("Enabled", mappingBindingSource, "CanApply");

                // Remove Mapping Button
                btnRemoveMapping.DataBindings.Add("Enabled", mappingBindingSource, "CanApply");

                // Activate and Deactivate Buttons
                btnActivate.DataBindings.Add("Enabled", mappingBindingSource, "CanApply");
                btnDeactivate.DataBindings.Add("Enabled", mappingBindingSource, "Activated");

                // Panel Visibility
                axisConfigControl.Visible = true;
                buttonConfigControl.Visible = true;
                encoderAxisControl.Visible = true;
                axisConfigControl.DataBindings.Add("Visible", mappingBindingSource, "IsAxisMapping");
                buttonConfigControl.DataBindings.Add("Visible", mappingBindingSource, "IsButtonMapping");
                encoderAxisControl.DataBindings.Add("Visible", mappingBindingSource, "IsEncoderAxisMapping");

                // axisConfigControl
                axisConfigControl.LoadFormData(ref _viewModel, ref mappingBindingSource);

                // buttonConfigControl
                buttonConfigControl.LoadFormData(ref _viewModel, ref mappingBindingSource);

                // encoderAxisControl
                encoderAxisControl.LoadFormData(ref _viewModel, ref mappingBindingSource);
            }

            // Update Selected Mapping
            if (mappingBindingSource.Current is MappingViewModel mappingViewModel)
            {
                mappingViewModel.Name = tbName.Text;
                tbName.SelectionStart = tbName.Text.Length;
                tbName.SelectionLength = 0;
            }

        }
        private void configMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.Equals("saveMenuItem"))
            {
                try
                {
                    _viewModel.SaveMappings();
                    MessageBox.Show("Your config has been saved", "Saved",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while saving",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _viewModel.Stop();
                }

            }
            else if (e.ClickedItem.Name.Equals("loadMenuItem"))
            {
                try
                {
                    _viewModel.LoadMappings();
                    LoadFormData();
                    MessageBox.Show("Your config has been loaded", "Loaded",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error while loading",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _viewModel.Stop();
                }
            }
        }

        private void presetsMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name.Equals("clearMenuItem"))
                {
                    _viewModel.Reset(Aircraft.NONE);
                }
                else if (e.ClickedItem.Name.Equals("spitfireMkIXMenuItem"))
                {
                    _viewModel.Reset(Aircraft.SPITFIRE_MKIX);
                }
                LoadFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error while resetting",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        private void helpMenuItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem.Name.Equals("userGuideMenuItem"))
                {
                    ProcessStartInfo sInfo = new(@"Readme\index.html")
                    {
                        UseShellExecute = true
                    };
                    Process.Start(sInfo);
                } else if (e.ClickedItem.Name.Equals("bugReportMenuItem"))
                {
                    ProcessStartInfo sInfo = new(@"Readme\index.html")
                    {
                        UseShellExecute = true
                    };
                    Process.Start(sInfo);
                }
                else if (e.ClickedItem.Name.Equals("aboutToolStripMenuItem"))
                {
                    string message = String.Format("AuthentiKit Tuning App ({0})\n\n" +
                        "Authored by Ian Colman and licensed under CC BY NC ND 4.0.\n\n" +
                        "You cand find more details at the readme pages. Would you like to go there now?",
                        VERSION);
                    string title = "Raise a bug";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        ProcessStartInfo sInfo = new(@"Readme\index.html")
                        {
                            UseShellExecute = true
                        };
                        Process.Start(sInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error displaying help windows",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (mappingBindingSource.Current is MappingViewModel mappingViewModel
                    && mappingViewModel.Deactivated)
                {
                    mappingViewModel.Activate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error activating mapping",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        private void btnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                if (mappingBindingSource.Current is MappingViewModel mappingViewModel
                    && mappingViewModel.Activated)
                {
                    mappingViewModel.Deactivate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error deactivating mapping",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                _viewModel.Stop();
            }
        }

        /*
         * The following methods only exist to trigger an update of the data binding without having to
         * select another control. The main way that data is updated in the mapping is via the databindings
         * specified in the LoadFormData above.
         */
        private void cbMappingType_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((mappingBindingSource.Current is MappingViewModel mappingViewModel) && (_viewModel.Mappings.Count > 0))
            {
                if (cbMappingType.SelectedValue != null)
                {
                    string selected = cbMappingType.SelectedValue.ToString();
                    if (selected.Equals("0") || selected.Equals("1") || selected.Equals("2"))
                        mappingViewModel.TypeId = int.Parse(selected);
                }
            }
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            if ((mappingBindingSource.Current is MappingViewModel mappingViewModel) && (_viewModel.Mappings.Count > 0))
            {
                mappingViewModel.Name = tbName.Text;
                tbName.SelectionStart = tbName.Text.Length;
                tbName.SelectionLength = 0;
            }
        }

        private void InitalSetup()
        {
            if (!_viewModel.AtLeastOneMapping)
            {
                try
                {
                    _viewModel.NewMapping();
                    LoadFormData();
                    lsbMappings.SelectedIndex = lsbMappings.Items.Count - 1;
                    if (mappingBindingSource.Current is MappingViewModel mappingViewModel)
                    {
                        _viewModel.RemoveMapping(mappingViewModel);
                    }
                    LoadFormData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error starting up",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _viewModel.Stop();
                }
            }
        }
    }
}
