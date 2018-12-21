using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GitIdentityManager
{
    public partial class GitIdentityManager : Form
    {
        // assumptions:
        // user.name set
        // user.email set
        // (user.name, user.email) uniquely identify
        Dictionary<string, string>[] _identities;

        public static string Git(string command)
        {
            var p = Process.Start(new ProcessStartInfo
            {
                FileName = "git",
                Arguments = command,
                WorkingDirectory = Directory.GetCurrentDirectory(),
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = true,
            });
            p.WaitForExit();
            return p.ExitCode == 0 ? p.StandardOutput.ReadToEnd().Trim() : "";
        }

        public GitIdentityManager()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location) + ".json");
            try
            {
                _identities = JsonConvert.DeserializeObject<Dictionary<string, string>[]>(File.ReadAllText(configPath));
            }
            catch
            {
                Environment.Exit(1);
            }
            var name = Git("config --local user.name");
            var email = Git("config --local user.email");
            var idIdx = 0;
            for (var i = 0; i < _identities.Length; i++)
            {
                if (name == _identities[i]["user.name"] && email == _identities[i]["user.email"])
                {
                    idIdx = i;
                    break;
                }
            }
            listBoxIdentities.DataSource = _identities.Select(id => $"{id["user.name"]} <{id["user.email"]}>").ToArray();
            listBoxIdentities.SelectedIndex = idIdx;
            listBoxIdentities.SelectedIndexChanged += ListBoxIdentities_SelectedIndexChanged;
            ListBoxIdentities_SelectedIndexChanged(this, null);
            listBoxIdentities.DoubleClick += ListBoxIdentities_DoubleClick;
            listBoxIdentities.KeyDown += ListBoxIdentities_KeyDown;
        }

        private void ListBoxIdentities_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                buttonSave_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ListBoxIdentities_DoubleClick(object sender, EventArgs e)
        {
            buttonSave_Click(sender, e);
        }

        private void ListBoxIdentities_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxDetails.Text = string.Join("\r\n", _identities[listBoxIdentities.SelectedIndex].Select(id => id.Key + "\t\t" + id.Value));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var id = _identities[listBoxIdentities.SelectedIndex];
            foreach (var kv in id)
                Git($"config \"{kv.Key}\" \"{kv.Value}\"");
            Environment.Exit(0);
        }
    }
}
