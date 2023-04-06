﻿using System;
using System.Collections.ObjectModel;
using Vortice.MediaFoundation;

namespace MFAudioDeviceEnumeratorVorticeWpfApp.AudioManager.AudioDeviceManager
{
    public interface IAudioDeviceManager : IMMNotificationClient, IDisposable
    {
        IAudioDevice Default { get; set; }
        ObservableCollection<IAudioDevice> Devices { get; }
        AudioDeviceKind Kind { get; }
        event EventHandler DefaultChanged;
    }
}