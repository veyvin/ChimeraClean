﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Chimera.Config;

namespace Chimera.ConfigurationTool.Controls {
    public partial class ConfigurationObjectControlPanel : UserControl {
        ConfigBase mConfig;

        public ConfigurationObjectControlPanel() {
            InitializeComponent();
        }

        public ConfigurationObjectControlPanel(ConfigBase config)
            : this() {
            mConfig = config;

            foreach (var parameter in mConfig.Parameters.OrderBy(p => p.Section)) {
                LoadParameter(parameter);
            }
        }

        public ConfigurationObjectControlPanel(ConfigBase config, string frame)
            : this() {
            mConfig = config;

            foreach (var parameter in mConfig.Parameters.Where(p => p.Section == frame)) {
                LoadParameter(parameter);
            }
        }

        public ConfigurationObjectControlPanel(ConfigBase config, string[] frames)
            : this() {
            mConfig = config;

            foreach (var parameter in mConfig.Parameters.Where(p => !frames.Contains(p.Section))) {
                LoadParameter(parameter);
            }
        }

        private void LoadParameter(ConfigParam parameter) {
            int row = parametersList.Rows.Add(parameter.Key, parameter, parameter.Default, parameter.Section, parameter.Description);
        }

    }
}
