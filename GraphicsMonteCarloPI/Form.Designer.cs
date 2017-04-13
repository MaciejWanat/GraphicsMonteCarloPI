namespace GraphicsMonteCarloPI
{
    partial class Form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tnrAppTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tnrAppTimer
            // 
            this.tnrAppTimer.Enabled = true;
            this.tnrAppTimer.Interval = 10;
            this.tnrAppTimer.Tick += new System.EventHandler(this.tnrAppTimer_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 803);
            this.Name = "Form";
            this.Text = "PIMonteCarlo";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tnrAppTimer;
    }
}

