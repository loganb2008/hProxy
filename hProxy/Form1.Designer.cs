
namespace hProxy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.exit = new System.Windows.Forms.Button();
            this.plist = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(713, 415);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // plist
            // 
            this.plist.IsWebBrowserContextMenuEnabled = false;
            this.plist.Location = new System.Drawing.Point(0, 0);
            this.plist.MinimumSize = new System.Drawing.Size(20, 20);
            this.plist.Name = "plist";
            this.plist.ScrollBarsEnabled = false;
            this.plist.Size = new System.Drawing.Size(800, 409);
            this.plist.TabIndex = 4;
            this.plist.Url = new System.Uri("https://sudao.site/proxies/proxy.html", System.UriKind.Absolute);
            this.plist.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.plist_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plist);
            this.Controls.Add(this.exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "hProxy by Sudaox";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.WebBrowser plist;
    }
}

