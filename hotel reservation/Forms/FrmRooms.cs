namespace hotel_reservation.Forms
{
    internal class FrmRooms : FormRooms
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1209, 740);
            this.Name = "FrmRooms";
            this.Load += new System.EventHandler(this.FrmRooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmRooms_Load(object sender, System.EventArgs e)
        {

        }
    }
}