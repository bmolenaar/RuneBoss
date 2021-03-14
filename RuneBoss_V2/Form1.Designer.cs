namespace RuneBoss_V2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gbInv = new System.Windows.Forms.GroupBox();
            this.tpMelee = new System.Windows.Forms.TabPage();
            this.tpSupplies = new System.Windows.Forms.TabPage();
            this.tcItemList = new System.Windows.Forms.TabControl();
            this.tpMage = new System.Windows.Forms.TabPage();
            this.tpRanged = new System.Windows.Forms.TabPage();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.gbGear = new System.Windows.Forms.GroupBox();
            this.pbRing = new System.Windows.Forms.PictureBox();
            this.pbHands = new System.Windows.Forms.PictureBox();
            this.pbFeet = new System.Windows.Forms.PictureBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            this.pbShield = new System.Windows.Forms.PictureBox();
            this.pbWeapon = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbAmmo = new System.Windows.Forms.PictureBox();
            this.pbCape = new System.Windows.Forms.PictureBox();
            this.pbNeck = new System.Windows.Forms.PictureBox();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsBoss = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSlayer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSkilling = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.btnResetGear = new System.Windows.Forms.Button();
            this.btnResetInv = new System.Windows.Forms.Button();
            this.tpMisc = new System.Windows.Forms.TabPage();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tcItemList.SuspendLayout();
            this.gbGear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShield)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCape)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInv
            // 
            this.gbInv.Location = new System.Drawing.Point(455, 94);
            this.gbInv.Name = "gbInv";
            this.gbInv.Size = new System.Drawing.Size(287, 508);
            this.gbInv.TabIndex = 1;
            this.gbInv.TabStop = false;
            this.gbInv.Text = "Inventory";
            // 
            // tpMelee
            // 
            this.tpMelee.Location = new System.Drawing.Point(4, 22);
            this.tpMelee.Name = "tpMelee";
            this.tpMelee.Padding = new System.Windows.Forms.Padding(3);
            this.tpMelee.Size = new System.Drawing.Size(412, 508);
            this.tpMelee.TabIndex = 1;
            this.tpMelee.Text = "Gear(Melee)";
            this.tpMelee.UseVisualStyleBackColor = true;
            // 
            // tpSupplies
            // 
            this.tpSupplies.Location = new System.Drawing.Point(4, 22);
            this.tpSupplies.Name = "tpSupplies";
            this.tpSupplies.Padding = new System.Windows.Forms.Padding(3);
            this.tpSupplies.Size = new System.Drawing.Size(412, 508);
            this.tpSupplies.TabIndex = 0;
            this.tpSupplies.Text = "Supplies";
            this.tpSupplies.UseVisualStyleBackColor = true;
            // 
            // tcItemList
            // 
            this.tcItemList.Controls.Add(this.tpSupplies);
            this.tcItemList.Controls.Add(this.tpMelee);
            this.tcItemList.Controls.Add(this.tpMage);
            this.tcItemList.Controls.Add(this.tpRanged);
            this.tcItemList.Controls.Add(this.tpMisc);
            this.tcItemList.Location = new System.Drawing.Point(12, 72);
            this.tcItemList.Name = "tcItemList";
            this.tcItemList.SelectedIndex = 0;
            this.tcItemList.Size = new System.Drawing.Size(420, 534);
            this.tcItemList.TabIndex = 6;
            // 
            // tpMage
            // 
            this.tpMage.Location = new System.Drawing.Point(4, 22);
            this.tpMage.Name = "tpMage";
            this.tpMage.Size = new System.Drawing.Size(412, 508);
            this.tpMage.TabIndex = 2;
            this.tpMage.Text = "Gear(Magic)";
            this.tpMage.UseVisualStyleBackColor = true;
            // 
            // tpRanged
            // 
            this.tpRanged.Location = new System.Drawing.Point(4, 22);
            this.tpRanged.Name = "tpRanged";
            this.tpRanged.Size = new System.Drawing.Size(412, 508);
            this.tpRanged.TabIndex = 3;
            this.tpRanged.Text = "Gear(Ranged)";
            this.tpRanged.UseVisualStyleBackColor = true;
            // 
            // gbGear
            // 
            this.gbGear.Controls.Add(this.pbRing);
            this.gbGear.Controls.Add(this.pbHands);
            this.gbGear.Controls.Add(this.pbFeet);
            this.gbGear.Controls.Add(this.pbLegs);
            this.gbGear.Controls.Add(this.pbShield);
            this.gbGear.Controls.Add(this.pbWeapon);
            this.gbGear.Controls.Add(this.pbBody);
            this.gbGear.Controls.Add(this.pbAmmo);
            this.gbGear.Controls.Add(this.pbCape);
            this.gbGear.Controls.Add(this.pbNeck);
            this.gbGear.Controls.Add(this.pbHead);
            this.gbGear.Location = new System.Drawing.Point(791, 94);
            this.gbGear.Name = "gbGear";
            this.gbGear.Size = new System.Drawing.Size(287, 508);
            this.gbGear.TabIndex = 2;
            this.gbGear.TabStop = false;
            this.gbGear.Text = "Gear";
            // 
            // pbRing
            // 
            this.pbRing.Location = new System.Drawing.Point(186, 353);
            this.pbRing.Name = "pbRing";
            this.pbRing.Size = new System.Drawing.Size(60, 60);
            this.pbRing.TabIndex = 10;
            this.pbRing.TabStop = false;
            // 
            // pbHands
            // 
            this.pbHands.Location = new System.Drawing.Point(54, 353);
            this.pbHands.Name = "pbHands";
            this.pbHands.Size = new System.Drawing.Size(60, 60);
            this.pbHands.TabIndex = 9;
            this.pbHands.TabStop = false;
            // 
            // pbFeet
            // 
            this.pbFeet.Location = new System.Drawing.Point(120, 353);
            this.pbFeet.Name = "pbFeet";
            this.pbFeet.Size = new System.Drawing.Size(60, 60);
            this.pbFeet.TabIndex = 8;
            this.pbFeet.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(120, 287);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(60, 60);
            this.pbLegs.TabIndex = 7;
            this.pbLegs.TabStop = false;
            // 
            // pbShield
            // 
            this.pbShield.Location = new System.Drawing.Point(186, 221);
            this.pbShield.Name = "pbShield";
            this.pbShield.Size = new System.Drawing.Size(60, 60);
            this.pbShield.TabIndex = 6;
            this.pbShield.TabStop = false;
            // 
            // pbWeapon
            // 
            this.pbWeapon.Location = new System.Drawing.Point(54, 221);
            this.pbWeapon.Name = "pbWeapon";
            this.pbWeapon.Size = new System.Drawing.Size(60, 60);
            this.pbWeapon.TabIndex = 5;
            this.pbWeapon.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.Location = new System.Drawing.Point(120, 221);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(60, 60);
            this.pbBody.TabIndex = 4;
            this.pbBody.TabStop = false;
            // 
            // pbAmmo
            // 
            this.pbAmmo.Location = new System.Drawing.Point(186, 155);
            this.pbAmmo.Name = "pbAmmo";
            this.pbAmmo.Size = new System.Drawing.Size(60, 60);
            this.pbAmmo.TabIndex = 3;
            this.pbAmmo.TabStop = false;
            // 
            // pbCape
            // 
            this.pbCape.Location = new System.Drawing.Point(54, 155);
            this.pbCape.Name = "pbCape";
            this.pbCape.Size = new System.Drawing.Size(60, 60);
            this.pbCape.TabIndex = 2;
            this.pbCape.TabStop = false;
            // 
            // pbNeck
            // 
            this.pbNeck.Location = new System.Drawing.Point(120, 155);
            this.pbNeck.Name = "pbNeck";
            this.pbNeck.Size = new System.Drawing.Size(60, 60);
            this.pbNeck.TabIndex = 1;
            this.pbNeck.TabStop = false;
            // 
            // pbHead
            // 
            this.pbHead.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbHead.InitialImage")));
            this.pbHead.Location = new System.Drawing.Point(120, 89);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(60, 60);
            this.pbHead.TabIndex = 0;
            this.pbHead.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(66, 34);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(362, 20);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(16, 34);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.tsBoss,
            this.tsSlayer,
            this.tsSkilling});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1158, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsBoss
            // 
            this.tsBoss.Name = "tsBoss";
            this.tsBoss.Size = new System.Drawing.Size(54, 20);
            this.tsBoss.Text = "Bosses";
            // 
            // tsSlayer
            // 
            this.tsSlayer.Name = "tsSlayer";
            this.tsSlayer.Size = new System.Drawing.Size(50, 20);
            this.tsSlayer.Text = "Slayer";
            // 
            // tsSkilling
            // 
            this.tsSkilling.Name = "tsSkilling";
            this.tsSkilling.Size = new System.Drawing.Size(57, 20);
            this.tsSkilling.Text = "Skilling";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(880, 34);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Setup";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(749, 34);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(125, 23);
            this.btnResetAll.TabIndex = 4;
            this.btnResetAll.Text = "Reset All";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // btnResetGear
            // 
            this.btnResetGear.Location = new System.Drawing.Point(618, 34);
            this.btnResetGear.Name = "btnResetGear";
            this.btnResetGear.Size = new System.Drawing.Size(125, 23);
            this.btnResetGear.TabIndex = 3;
            this.btnResetGear.Text = "Reset Gear";
            this.btnResetGear.UseVisualStyleBackColor = true;
            this.btnResetGear.Click += new System.EventHandler(this.btnResetGear_Click);
            // 
            // btnResetInv
            // 
            this.btnResetInv.Location = new System.Drawing.Point(487, 34);
            this.btnResetInv.Name = "btnResetInv";
            this.btnResetInv.Size = new System.Drawing.Size(125, 23);
            this.btnResetInv.TabIndex = 2;
            this.btnResetInv.Text = "Reset Inventory";
            this.btnResetInv.UseVisualStyleBackColor = true;
            this.btnResetInv.Click += new System.EventHandler(this.btnResetInv_Click);
            // 
            // tpMisc
            // 
            this.tpMisc.Location = new System.Drawing.Point(4, 22);
            this.tpMisc.Name = "tpMisc";
            this.tpMisc.Size = new System.Drawing.Size(412, 508);
            this.tpMisc.TabIndex = 4;
            this.tpMisc.Text = "Misc.";
            this.tpMisc.UseVisualStyleBackColor = true;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 649);
            this.Controls.Add(this.btnResetInv);
            this.Controls.Add(this.btnResetGear);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.gbGear);
            this.Controls.Add(this.gbInv);
            this.Controls.Add(this.tcItemList);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "RuneBoss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tcItemList.ResumeLayout(false);
            this.gbGear.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbRing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShield)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCape)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNeck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbInv;
        private System.Windows.Forms.TabPage tpMelee;
        private System.Windows.Forms.TabPage tpSupplies;
        private System.Windows.Forms.TabControl tcItemList;
        private System.Windows.Forms.ToolTip MyToolTip;
        private System.Windows.Forms.TabPage tpMage;
        private System.Windows.Forms.TabPage tpRanged;
        private System.Windows.Forms.GroupBox gbGear;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbRing;
        private System.Windows.Forms.PictureBox pbHands;
        private System.Windows.Forms.PictureBox pbFeet;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.PictureBox pbShield;
        private System.Windows.Forms.PictureBox pbWeapon;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbAmmo;
        private System.Windows.Forms.PictureBox pbCape;
        private System.Windows.Forms.PictureBox pbNeck;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsBoss;
        private System.Windows.Forms.ToolStripMenuItem tsSlayer;
        private System.Windows.Forms.ToolStripMenuItem tsSkilling;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.Button btnResetGear;
        private System.Windows.Forms.Button btnResetInv;
        private System.Windows.Forms.TabPage tpMisc;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

