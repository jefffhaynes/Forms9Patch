﻿using System;
using Forms9Patch.Interfaces;
using Xamarin.Forms;

namespace Forms9Patch
{
    public static class Haptics
    {
        static Haptics()
            => Settings.ConfirmInitialization();

        static IHapticsService _service;
        static IHapticsService Service => _service = _service ?? DependencyService.Get<IHapticsService>();

        public static void Feedback(HapticEffect effect, EffectMode mode = default)
            => Service?.Feedback(effect, mode);

    }
}
