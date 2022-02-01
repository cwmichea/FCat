namespace FCat
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
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.scoreText = new System.Windows.Forms.Label();
            this.labelPause = new System.Windows.Forms.Label();
            this.bunny = new System.Windows.Forms.PictureBox();
            this.catFood = new System.Windows.Forms.PictureBox();
            this.petitC0 = new System.Windows.Forms.PictureBox();
            this.dog = new System.Windows.Forms.PictureBox();
            this.petitC3 = new System.Windows.Forms.PictureBox();
            this.mountain = new System.Windows.Forms.PictureBox();
            this.petitC4 = new System.Windows.Forms.PictureBox();
            this.petitC5 = new System.Windows.Forms.PictureBox();
            this.petitC1 = new System.Windows.Forms.PictureBox();
            this.petitC2 = new System.Windows.Forms.PictureBox();
            this.Cloud2 = new System.Windows.Forms.PictureBox();
            this.Cloud3 = new System.Windows.Forms.PictureBox();
            this.Cloud1 = new System.Windows.Forms.PictureBox();
            this.cat = new System.Windows.Forms.PictureBox();
            this.hit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.catFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hit)).BeginInit();
            this.SuspendLayout();
            // 
            // gametimer
            // 
            this.gametimer.Enabled = true;
            this.gametimer.Interval = 20;
            this.gametimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.Location = new System.Drawing.Point(681, 9);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(100, 31);
            this.scoreText.TabIndex = 7;
            this.scoreText.Text = "Score: ";
            // 
            // labelPause
            // 
            this.labelPause.AutoSize = true;
            this.labelPause.Font = new System.Drawing.Font("Lucida Handwriting", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPause.Location = new System.Drawing.Point(457, 313);
            this.labelPause.Name = "labelPause";
            this.labelPause.Size = new System.Drawing.Size(111, 31);
            this.labelPause.TabIndex = 14;
            this.labelPause.Text = "Paused";
            // 
            // bunny
            // 
            this.bunny.BackColor = System.Drawing.Color.Transparent;
            this.bunny.Image = global::FCat.Properties.Resources.bunny1;
            this.bunny.Location = new System.Drawing.Point(1046, 615);
            this.bunny.Name = "bunny";
            this.bunny.Size = new System.Drawing.Size(50, 49);
            this.bunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunny.TabIndex = 16;
            this.bunny.TabStop = false;
            // 
            // catFood
            // 
            this.catFood.Image = global::FCat.Properties.Resources.catfoodpsd;
            this.catFood.Location = new System.Drawing.Point(542, 364);
            this.catFood.Name = "catFood";
            this.catFood.Size = new System.Drawing.Size(74, 81);
            this.catFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.catFood.TabIndex = 15;
            this.catFood.TabStop = false;
            // 
            // petitC0
            // 
            this.petitC0.BackColor = System.Drawing.Color.Transparent;
            this.petitC0.Image = global::FCat.Properties.Resources.Cloud4;
            this.petitC0.Location = new System.Drawing.Point(463, 167);
            this.petitC0.Name = "petitC0";
            this.petitC0.Size = new System.Drawing.Size(50, 49);
            this.petitC0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petitC0.TabIndex = 12;
            this.petitC0.TabStop = false;
            // 
            // dog
            // 
            this.dog.BackColor = System.Drawing.Color.Transparent;
            this.dog.Image = global::FCat.Properties.Resources.FlyingDog;
            this.dog.Location = new System.Drawing.Point(1072, 69);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(171, 130);
            this.dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog.TabIndex = 11;
            this.dog.TabStop = false;
            // 
            // petitC3
            // 
            this.petitC3.BackColor = System.Drawing.Color.Transparent;
            this.petitC3.Image = global::FCat.Properties.Resources.Cloud4;
            this.petitC3.Location = new System.Drawing.Point(962, 579);
            this.petitC3.Name = "petitC3";
            this.petitC3.Size = new System.Drawing.Size(50, 49);
            this.petitC3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petitC3.TabIndex = 6;
            this.petitC3.TabStop = false;
            // 
            // mountain
            // 
            this.mountain.BackColor = System.Drawing.Color.Transparent;
            this.mountain.Image = global::FCat.Properties.Resources.mountain1;
            this.mountain.Location = new System.Drawing.Point(805, 602);
            this.mountain.Name = "mountain";
            this.mountain.Size = new System.Drawing.Size(207, 62);
            this.mountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mountain.TabIndex = 10;
            this.mountain.TabStop = false;
            // 
            // petitC4
            // 
            this.petitC4.BackColor = System.Drawing.Color.Transparent;
            this.petitC4.Image = global::FCat.Properties.Resources.Cloud4;
            this.petitC4.Location = new System.Drawing.Point(1072, 278);
            this.petitC4.Name = "petitC4";
            this.petitC4.Size = new System.Drawing.Size(99, 66);
            this.petitC4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petitC4.TabIndex = 9;
            this.petitC4.TabStop = false;
            // 
            // petitC5
            // 
            this.petitC5.BackColor = System.Drawing.Color.Transparent;
            this.petitC5.Image = global::FCat.Properties.Resources.Cloud4;
            this.petitC5.Location = new System.Drawing.Point(395, 222);
            this.petitC5.Name = "petitC5";
            this.petitC5.Size = new System.Drawing.Size(95, 55);
            this.petitC5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petitC5.TabIndex = 8;
            this.petitC5.TabStop = false;
            // 
            // petitC1
            // 
            this.petitC1.BackColor = System.Drawing.Color.Transparent;
            this.petitC1.Image = global::FCat.Properties.Resources.Cloud4;
            this.petitC1.Location = new System.Drawing.Point(291, 93);
            this.petitC1.Name = "petitC1";
            this.petitC1.Size = new System.Drawing.Size(77, 55);
            this.petitC1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petitC1.TabIndex = 5;
            this.petitC1.TabStop = false;
            // 
            // petitC2
            // 
            this.petitC2.BackColor = System.Drawing.Color.Transparent;
            this.petitC2.Image = global::FCat.Properties.Resources.Cloud4;
            this.petitC2.Location = new System.Drawing.Point(585, 161);
            this.petitC2.Name = "petitC2";
            this.petitC2.Size = new System.Drawing.Size(90, 55);
            this.petitC2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.petitC2.TabIndex = 4;
            this.petitC2.TabStop = false;
            // 
            // Cloud2
            // 
            this.Cloud2.BackColor = System.Drawing.Color.Transparent;
            this.Cloud2.Image = global::FCat.Properties.Resources.Cloud3;
            this.Cloud2.Location = new System.Drawing.Point(463, 69);
            this.Cloud2.Name = "Cloud2";
            this.Cloud2.Size = new System.Drawing.Size(212, 147);
            this.Cloud2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud2.TabIndex = 3;
            this.Cloud2.TabStop = false;
            // 
            // Cloud3
            // 
            this.Cloud3.BackColor = System.Drawing.Color.Transparent;
            this.Cloud3.Image = global::FCat.Properties.Resources.Cloud2;
            this.Cloud3.Location = new System.Drawing.Point(687, 525);
            this.Cloud3.Name = "Cloud3";
            this.Cloud3.Size = new System.Drawing.Size(166, 139);
            this.Cloud3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud3.TabIndex = 2;
            this.Cloud3.TabStop = false;
            // 
            // Cloud1
            // 
            this.Cloud1.BackColor = System.Drawing.Color.Transparent;
            this.Cloud1.Image = global::FCat.Properties.Resources.Cloud1;
            this.Cloud1.Location = new System.Drawing.Point(291, 1);
            this.Cloud1.Name = "Cloud1";
            this.Cloud1.Size = new System.Drawing.Size(210, 147);
            this.Cloud1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Cloud1.TabIndex = 1;
            this.Cloud1.TabStop = false;
            // 
            // cat
            // 
            this.cat.AccessibleName = "cat";
            this.cat.Image = global::FCat.Properties.Resources.FlyingCat;
            this.cat.Location = new System.Drawing.Point(12, 245);
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(113, 89);
            this.cat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cat.TabIndex = 0;
            this.cat.TabStop = false;
            // 
            // hit
            // 
            this.hit.Image = ((System.Drawing.Image)(resources.GetObject("hit.Image")));
            this.hit.Location = new System.Drawing.Point(3, 245);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(146, 116);
            this.hit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hit.TabIndex = 13;
            this.hit.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1093, 665);
            this.Controls.Add(this.bunny);
            this.Controls.Add(this.catFood);
            this.Controls.Add(this.labelPause);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.petitC0);
            this.Controls.Add(this.dog);
            this.Controls.Add(this.petitC3);
            this.Controls.Add(this.mountain);
            this.Controls.Add(this.petitC4);
            this.Controls.Add(this.petitC5);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.petitC1);
            this.Controls.Add(this.petitC2);
            this.Controls.Add(this.Cloud2);
            this.Controls.Add(this.Cloud3);
            this.Controls.Add(this.Cloud1);
            this.Controls.Add(this.cat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KUp);
            ((System.ComponentModel.ISupportInitialize)(this.bunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.catFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petitC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cloud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox cat;
        private System.Windows.Forms.PictureBox Cloud1;
        private System.Windows.Forms.PictureBox Cloud3;
        private System.Windows.Forms.PictureBox Cloud2;
        private System.Windows.Forms.PictureBox petitC2;
        private System.Windows.Forms.PictureBox petitC1;
        private System.Windows.Forms.PictureBox petitC3;
        private System.Windows.Forms.Label scoreText;
        public System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.PictureBox petitC5;
        private System.Windows.Forms.PictureBox petitC4;
        private System.Windows.Forms.PictureBox mountain;
        private System.Windows.Forms.PictureBox dog;
        private System.Windows.Forms.PictureBox petitC0;
        private System.Windows.Forms.Label labelPause;
        private System.Windows.Forms.PictureBox catFood;
        private System.Windows.Forms.PictureBox bunny;
        private System.Windows.Forms.PictureBox hit;
    }
}

