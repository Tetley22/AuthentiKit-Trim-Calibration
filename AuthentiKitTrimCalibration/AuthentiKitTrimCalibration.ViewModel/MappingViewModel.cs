﻿using AuthentiKitTrimCalibration.DataAccess;
using MappingManager.Common.DataProvider;
using MappingManager.Common.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace AuthentiKitTrimCalibration.ViewModel
{
    public class MappingViewModel : ViewModelBase
    {
        private IMappingProcessor _mappingProcessor;
        private MappingDTO _mapping;
        private ObservableCollection<InputChannel> InputChannels;
        private ObservableCollection<OutputChannel> OutputChannels;

        public MappingViewModel(MappingDTO mapping, ObservableCollection<InputChannel> inputs, ObservableCollection<OutputChannel> outputs)
        {
            InputChannels = inputs;
            OutputChannels = outputs;
            _mappingProcessor = new MappingProcessor();
            _mapping = mapping;
            Deactivate();
        }

        private void UpdateStatus()
        {
            RaisePropertyChanged(nameof(Activated));
            RaisePropertyChanged(nameof(Deactivated));
            RaisePropertyChanged(nameof(Status));
            RaisePropertyChanged(nameof(StatusColour));
        }
        public void Activate()
        {
            _mappingProcessor.Activate(_mapping);
            UpdateStatus();
        }
        public void Deactivate()
        {
            _mappingProcessor.Deactivate();
            UpdateStatus();
        }
        public void CentreAxis()
        {
            _mappingProcessor.Centre();
            UpdateStatus();
        }

        public bool CanApply => !string.IsNullOrEmpty(Name) && Deactivated;
        public bool IsAxisMapping => TypeId == MappingType.AXIS;
        public bool IsButtonMapping => TypeId == MappingType.BUTTON;

        public string Name
        {
            get { return _mapping.Name; }
            set
            {
                if (_mapping.Name != value)
                {
                    Deactivate();
                    _mapping.Name = value;
                    RaisePropertyChanged();
                    RaisePropertyChanged(nameof(CanApply));
                    UpdateStatus();
                }
            }
        }

        public string Status
        {
            get
            {
                string status = "Deactivated";
                if (_mappingProcessor.IsErrored())
                {
                    status = "Error!";
                }
                else if (_mappingProcessor.IsRunning())
                {
                    status = "Activated";
                }
                return status;
            }
        }
        public string StatusColour
        {
            get
            {
                string status = "Gray"; // Deactivated
                if (_mappingProcessor.IsErrored())
                {
                    status = "Salmon"; // Error
                }
                else if (_mappingProcessor.IsRunning())
                {
                    status = "Green"; // Activated
                }
                return status;
            }
        }
        public int TypeId
        {
            get => _mapping.TypeId;
            set
            {
                if (_mapping.TypeId != value)
                {
                    _mapping.TypeId = value;
                    RaisePropertyChanged();
                }
            }
        }

        public int InputChannelAId
        {
            get => _mapping.InputChannelA.Id;
            set
            {
                if (_mapping.InputChannelA.Id != value)
                {
                    _mapping.InputChannelA = GetInputChannel(value);
                    RaisePropertyChanged();
                }
            }
        }

        public int InputChannelBId
        {
            get => _mapping.InputChannelB.Id;
            set
            {
                if (_mapping.InputChannelB.Id != value)
                {
                    _mapping.InputChannelB = GetInputChannel(value);
                    RaisePropertyChanged();
                }
            }
        }
        public int OutputChannelId
        {
            get => _mapping.OutputChannel.Id;
            set
            {
                if (_mapping.OutputChannel.Id != value)
                {
                    _mapping.OutputChannel = GetOutputChannel(value);
                    RaisePropertyChanged();
                }
            }
        }
        private InputChannel GetInputChannel(int id)
        {
            Debug.WriteLine("Getting input for id " + id);
            for (int i = 0; i < InputChannels.Count; i++)
            {
                if (id == InputChannels[i].Id)
                {
                    Debug.WriteLine("Found " + InputChannels[i]);
                    return InputChannels[i];
                }
            }
            Debug.WriteLine("Not Found anything");
            return new InputChannel();
        }
        private OutputChannel GetOutputChannel(int id)
        {
            for (int i = 0; i < OutputChannels.Count; i++)
            {
                if (id == OutputChannels[i].Id)
                {
                    return OutputChannels[i];
                }
            }
            return new OutputChannel();
        }

        public int Multiplier
        {
            get { return _mapping.Multiplier; }
            set
            {
                if (_mapping.Multiplier != value)
                {
                    Deactivate();
                    _mapping.Multiplier = value;
                    RaisePropertyChanged();
                    UpdateStatus();
                }
            }
        }
        public int HoldThresholdStart
        {
            get { return _mapping.HoldThresholdStart; }
            set
            {
                if (_mapping.HoldThresholdStart != value)
                {
                    Deactivate();
                    _mapping.HoldThresholdStart = value;
                    RaisePropertyChanged();
                    UpdateStatus();
                }
            }
        }
        public int HoldThresholdStop
        {
            get { return _mapping.HoldThresholdStop; }
            set
            {
                if (_mapping.HoldThresholdStop != value)
                {
                    Deactivate();
                    _mapping.HoldThresholdStop = value;
                    RaisePropertyChanged();
                    UpdateStatus();
                }
            }
        }
        public string ResetCommand
        {
            get { return _mapping.ResetCommand; }
            set
            {
                if (_mapping.ResetCommand != value)
                {
                    Deactivate();
                    _mapping.ResetCommand = value;
                    RaisePropertyChanged();
                    UpdateStatus();
                }
            }
        }

        public bool Activated
        {
            get { return _mappingProcessor.IsRunning(); }
        }
        public bool Deactivated => !Activated;

    }
}
