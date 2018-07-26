namespace Login_with_new_form
{
    partial class MainForm
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
            this.fridge = new System.Windows.Forms.Button();
            this.ntoylapa = new System.Windows.Forms.Button();
            this.lights = new System.Windows.Forms.Button();
            this.heat = new System.Windows.Forms.Button();
            this.tv = new System.Windows.Forms.Button();
            this.radiofwno = new System.Windows.Forms.Button();
            this.kafetiera = new System.Windows.Forms.Button();
            this.vrastiras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fridge
            // 
            this.fridge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fridge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fridge.Location = new System.Drawing.Point(30, 73);
            this.fridge.Name = "fridge";
            this.fridge.Size = new System.Drawing.Size(75, 23);
            this.fridge.TabIndex = 0;
            this.fridge.Text = "ψυγειο";
            this.fridge.UseVisualStyleBackColor = true;
            this.fridge.Click += new System.EventHandler(this.fringe_Click);
            // 
            // ntoylapa
            // 
            this.ntoylapa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ntoylapa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ntoylapa.Location = new System.Drawing.Point(152, 73);
            this.ntoylapa.Name = "ntoylapa";
            this.ntoylapa.Size = new System.Drawing.Size(75, 23);
            this.ntoylapa.TabIndex = 1;
            this.ntoylapa.Text = "ντουλαπα";
            this.ntoylapa.UseVisualStyleBackColor = true;
            this.ntoylapa.Click += new System.EventHandler(this.ntoylapa_Click);
            // 
            // lights
            // 
            this.lights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lights.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lights.Location = new System.Drawing.Point(299, 73);
            this.lights.Name = "lights";
            this.lights.Size = new System.Drawing.Size(75, 23);
            this.lights.TabIndex = 2;
            this.lights.Text = "φωτα";
            this.lights.UseVisualStyleBackColor = true;
            this.lights.Click += new System.EventHandler(this.lights_Click);
            // 
            // heat
            // 
            this.heat.Location = new System.Drawing.Point(30, 144);
            this.heat.Name = "heat";
            this.heat.Size = new System.Drawing.Size(75, 23);
            this.heat.TabIndex = 3;
            this.heat.Text = "Θέρμανση";
            this.heat.UseVisualStyleBackColor = true;
            // 
            // tv
            // 
            this.tv.Location = new System.Drawing.Point(152, 143);
            this.tv.Name = "tv";
            this.tv.Size = new System.Drawing.Size(75, 23);
            this.tv.TabIndex = 4;
            this.tv.Text = "Τηλεόραση";
            this.tv.UseVisualStyleBackColor = true;
            // 
            // radiofwno
            // 
            this.radiofwno.Location = new System.Drawing.Point(299, 142);
            this.radiofwno.Name = "radiofwno";
            this.radiofwno.Size = new System.Drawing.Size(75, 23);
            this.radiofwno.TabIndex = 5;
            this.radiofwno.Text = "Ραδιόφωνο";
            this.radiofwno.UseVisualStyleBackColor = true;
            // 
            // kafetiera
            // 
            this.kafetiera.Location = new System.Drawing.Point(30, 200);
            this.kafetiera.Name = "kafetiera";
            this.kafetiera.Size = new System.Drawing.Size(75, 23);
            this.kafetiera.TabIndex = 6;
            this.kafetiera.Text = "Καφετιέρα";
            this.kafetiera.UseVisualStyleBackColor = true;
            // 
            // vrastiras
            // 
            this.vrastiras.Location = new System.Drawing.Point(152, 199);
            this.vrastiras.Name = "vrastiras";
            this.vrastiras.Size = new System.Drawing.Size(75, 23);
            this.vrastiras.TabIndex = 7;
            this.vrastiras.Text = "Βραστήρας";
            this.vrastiras.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 322);
            this.Controls.Add(this.vrastiras);
            this.Controls.Add(this.kafetiera);
            this.Controls.Add(this.radiofwno);
            this.Controls.Add(this.tv);
            this.Controls.Add(this.heat);
            this.Controls.Add(this.lights);
            this.Controls.Add(this.ntoylapa);
            this.Controls.Add(this.fridge);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fridge;
        private System.Windows.Forms.Button ntoylapa;
        private System.Windows.Forms.Button lights;
        private System.Windows.Forms.Button heat;
        private System.Windows.Forms.Button tv;
        private System.Windows.Forms.Button radiofwno;
        private System.Windows.Forms.Button kafetiera;
        private System.Windows.Forms.Button vrastiras;
    }
}