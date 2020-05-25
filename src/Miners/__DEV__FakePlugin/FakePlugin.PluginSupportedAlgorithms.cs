﻿using NHM.MinerPluginToolkitV1.Configs;
using NHM.Common.Enums;
using System.Collections.Generic;

using SAS = NHM.MinerPluginToolkitV1.Configs.PluginSupportedAlgorithmsSettings.SupportedAlgorithmSettings;

namespace FakePlugin
{
    public partial class FakePlugin
    {
        protected override PluginSupportedAlgorithmsSettings DefaultPluginSupportedAlgorithmsSettings => new PluginSupportedAlgorithmsSettings
        {
            // fee fixed
            DefaultFee = 2.0,
            AlgorithmFees = new Dictionary<AlgorithmType, double>
            {
                { AlgorithmType.Cuckaroom, 3.0 },
            },
            Algorithms = new Dictionary<DeviceType, List<SAS>>
            {
                {
                    DeviceType.NVIDIA,
                    new List<SAS>
                    {
                        new SAS(AlgorithmType.ZHash),
                        new SAS(AlgorithmType.GrinCuckatoo31),
                        new SAS(AlgorithmType.CuckooCycle) {Enabled = false },
                        new SAS(AlgorithmType.GrinCuckarood29),
                        new SAS(AlgorithmType.BeamV2),
                        new SAS(AlgorithmType.Eaglesong),
                        new SAS(AlgorithmType.DaggerHashimoto, AlgorithmType.Eaglesong),
                        new SAS(AlgorithmType.Cuckaroom),
                        new SAS(AlgorithmType.GrinCuckatoo32),
                    }
                },
                {
                    DeviceType.AMD,
                    new List<SAS>
                    {
                        new SAS(AlgorithmType.CuckooCycle) {Enabled = false }, 
                        new SAS(AlgorithmType.BeamV2),
                        new SAS(AlgorithmType.Eaglesong),
                    }
                },
                {
                    DeviceType.CPU,
                    new List<SAS>
                    {
                        new SAS(AlgorithmType.RandomXmonero),
                        new SAS(AlgorithmType.Lyra2REv3),
                        new SAS(AlgorithmType.Eaglesong),
                    }
                },
            },
            AlgorithmNames = new Dictionary<AlgorithmType, string>
            {
                { AlgorithmType.ZHash, "ZHash" },
                { AlgorithmType.GrinCuckatoo31, "GrinCuckatoo31" },
                { AlgorithmType.CuckooCycle, "CuckooCycle" },
                { AlgorithmType.GrinCuckarood29, "GrinCuckarood29" },
                { AlgorithmType.BeamV2, "BeamV2" },
                { AlgorithmType.Eaglesong, "Eaglesong" },
                { AlgorithmType.Cuckaroom, "Cuckaroom" },
                { AlgorithmType.DaggerHashimoto, "DaggerHashimoto" },
                { AlgorithmType.GrinCuckatoo32, "GrinCuckatoo32" },
                { AlgorithmType.RandomXmonero, "RandomXmonero" },
                { AlgorithmType.Lyra2REv3, "Lyra2REv3" },
            }
        };
    }
}