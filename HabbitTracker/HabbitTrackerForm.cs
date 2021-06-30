using System;
using System.Configuration;
using System.Windows.Forms;

namespace HabbitTracker
{

    public partial class HabbitTrackerForm : Form
    {

        public class SessionStore
        {
            public String CurrentHabbit { get; set; }
        }

        SessionStore currentStore = new SessionStore { };

        private void RetrieveSessionInfo()
        {
            currentStore.CurrentHabbit = ConfigurationManager.AppSettings.Get("CurrentHabbit") != null ? ConfigurationManager.AppSettings.Get("CurrentHabbit") : "Your new habbit";
        }

        public HabbitTrackerForm()
        {
            RetrieveSessionInfo();
            InitializeComponent();
            enterHabbitTextBox.Text = currentStore.CurrentHabbit;
            currentHabbitLabel.Text = currentStore.CurrentHabbit;
        }

        private void addHabbitButton_Click(object sender, EventArgs e)
        {
            currentStore.CurrentHabbit = enterHabbitTextBox.Text;
            currentHabbitLabel.Text = currentStore.CurrentHabbit;
        }

        public void StoreSessionInfo()
        {
            foreach (var prop in currentStore.GetType().GetProperties())
            {
                AddUpdateAppSettings(prop.Name, prop.GetValue(currentStore, null).ToString());
            }
        }

        private static void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch (ConfigurationErrorsException)
            {
                Console.WriteLine("Error writing app settings");
            }
        }
    }
}

