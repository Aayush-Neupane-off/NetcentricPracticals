using System;
using System.Windows.Forms;

namespace NetcentricPracticals
{
    // Define delegate
    public delegate void ButtonClickHandler();

    // Publisher class
    class ButtonPublisher
    {
        public event ButtonClickHandler OnClick;

        public void Click()
        {
            Console.WriteLine("Button is clicked...");
            OnClick?.Invoke(); // trigger event
        }
    }

    public class DelegateEventDemo : Form
    {
        private Button guiButton;
        private ButtonPublisher publisherButton;

        public DelegateEventDemo()
        {
            this.Text = "Delegate & Event Demo";
            this.Width = 300;
            this.Height = 200;

            guiButton = new Button();
            guiButton.Text = "Click Me!";
            guiButton.Top = 50;
            guiButton.Left = 80;
            guiButton.Width = 120;
            guiButton.Height = 40;

            Controls.Add(guiButton);

            publisherButton = new ButtonPublisher();

            // Subscribe to custom event
            publisherButton.OnClick += () =>
            {
                MessageBox.Show("Event Handler: Button was clicked!");
            };

            // Link WinForms button click → our custom delegate event
            guiButton.Click += (sender, e) =>
            {
                publisherButton.Click();
            };
        }

        [STAThread]
        public static void Main()
        {
            // Fully qualified to avoid ambiguity with System.Net.Mime
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new DelegateEventDemo());
        }
    }
}
