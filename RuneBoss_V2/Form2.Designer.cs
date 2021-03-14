namespace RuneBoss_V2
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblBosses = new System.Windows.Forms.Label();
            this.cbBosses = new System.Windows.Forms.ComboBox();
            this.lblSlayer = new System.Windows.Forms.Label();
            this.cbSlayer = new System.Windows.Forms.ComboBox();
            this.lblSkilling = new System.Windows.Forms.Label();
            this.cbSkilling = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(197, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Save setup for:";
            // 
            // lblBosses
            // 
            this.lblBosses.AutoSize = true;
            this.lblBosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBosses.Location = new System.Drawing.Point(15, 112);
            this.lblBosses.Name = "lblBosses";
            this.lblBosses.Size = new System.Drawing.Size(56, 25);
            this.lblBosses.TabIndex = 1;
            this.lblBosses.Text = "Boss";
            // 
            // cbBosses
            // 
            this.cbBosses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBosses.DropDownWidth = 200;
            this.cbBosses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBosses.FormattingEnabled = true;
            this.cbBosses.Location = new System.Drawing.Point(108, 116);
            this.cbBosses.Name = "cbBosses";
            this.cbBosses.Size = new System.Drawing.Size(219, 28);
            this.cbBosses.TabIndex = 0;
            // 
            // lblSlayer
            // 
            this.lblSlayer.AutoSize = true;
            this.lblSlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlayer.Location = new System.Drawing.Point(15, 178);
            this.lblSlayer.Name = "lblSlayer";
            this.lblSlayer.Size = new System.Drawing.Size(68, 25);
            this.lblSlayer.TabIndex = 1;
            this.lblSlayer.Text = "Slayer";
            // 
            // cbSlayer
            // 
            this.cbSlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSlayer.FormattingEnabled = true;
            this.cbSlayer.Location = new System.Drawing.Point(108, 182);
            this.cbSlayer.Name = "cbSlayer";
            this.cbSlayer.Size = new System.Drawing.Size(219, 28);
            this.cbSlayer.TabIndex = 1;
            // 
            // lblSkilling
            // 
            this.lblSkilling.AutoSize = true;
            this.lblSkilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSkilling.Location = new System.Drawing.Point(15, 243);
            this.lblSkilling.Name = "lblSkilling";
            this.lblSkilling.Size = new System.Drawing.Size(74, 25);
            this.lblSkilling.TabIndex = 1;
            this.lblSkilling.Text = "Skilling";
            // 
            // cbSkilling
            // 
            this.cbSkilling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSkilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSkilling.FormattingEnabled = true;
            this.cbSkilling.Items.AddRange(new object[] {
            "Agility",
            "Attack",
            "Construction",
            "Cooking",
            "Crafting",
            "Defence",
            "Farming",
            "Firemaking",
            "Fishing",
            "Fletching",
            "Herblore",
            "Hitpoints",
            "Hunter",
            "Magic",
            "Mining",
            "Prayer",
            "Ranged",
            "Runecraft",
            "Slayer",
            "Smithing",
            "Strength",
            "Thieving",
            "Woodcutting"});
            this.cbSkilling.Location = new System.Drawing.Point(108, 247);
            this.cbSkilling.Name = "cbSkilling";
            this.cbSkilling.Size = new System.Drawing.Size(219, 28);
            this.cbSkilling.Sorted = true;
            this.cbSkilling.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(56, 303);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 48);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 376);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbSkilling);
            this.Controls.Add(this.cbSlayer);
            this.Controls.Add(this.lblSkilling);
            this.Controls.Add(this.cbBosses);
            this.Controls.Add(this.lblSlayer);
            this.Controls.Add(this.lblBosses);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Save Settings";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblBosses;
        private System.Windows.Forms.ComboBox cbBosses;
        private System.Windows.Forms.Label lblSlayer;
        private System.Windows.Forms.ComboBox cbSlayer;
        private System.Windows.Forms.Label lblSkilling;
        private System.Windows.Forms.ComboBox cbSkilling;
        private System.Windows.Forms.Button btnSave;
    }
}