namespace ITSWebBrowser
{
    partial class WebBrowserForm
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
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.btn_pass = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.BackColor = System.Drawing.Color.White;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(2, 1);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(796, 449);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // btn_pass
            // 
            this.btn_pass.BackColor = System.Drawing.Color.Transparent;
            this.btn_pass.BackgroundImage = global::ITSWebBrowser.Properties.Resources.white;
            this.btn_pass.FlatAppearance.BorderSize = 0;
            this.btn_pass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pass.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pass.Location = new System.Drawing.Point(706, 12);
            this.btn_pass.Name = "btn_pass";
            this.btn_pass.Size = new System.Drawing.Size(82, 28);
            this.btn_pass.TabIndex = 1;
            this.btn_pass.UseVisualStyleBackColor = false;
            this.btn_pass.Click += new System.EventHandler(this.btn_pass_Click);
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pass);
            this.Controls.Add(this.webView21);
            this.Name = "WebBrowserForm";
            this.Load += new System.EventHandler(this.WebBrowserForm_Load);
            this.SizeChanged += new System.EventHandler(this.WebBrowserForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private System.Windows.Forms.Button btn_pass;
    }
}

