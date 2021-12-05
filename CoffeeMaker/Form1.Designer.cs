namespace CoffeeMaker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listCoffeeMakers = new System.Windows.Forms.ComboBox();
            this.addGrainsBtn = new System.Windows.Forms.Button();
            this.addWaterBtn = new System.Windows.Forms.Button();
            this.cleanCoffeeMachineBtn = new System.Windows.Forms.Button();
            this.grainsGramNumeric = new System.Windows.Forms.NumericUpDown();
            this.waterVolumeNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.waterVolume = new System.Windows.Forms.Label();
            this.grainsGram = new System.Windows.Forms.Label();
            this.pollutionLevel = new System.Windows.Forms.Label();
            this.makeCoffeeBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mugVolumeList = new System.Windows.Forms.ComboBox();
            this.strengthCoffeeList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grainsGramNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterVolumeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // listCoffeeMakers
            // 
            this.listCoffeeMakers.FormattingEnabled = true;
            this.listCoffeeMakers.Location = new System.Drawing.Point(30, 235);
            this.listCoffeeMakers.Name = "listCoffeeMakers";
            this.listCoffeeMakers.Size = new System.Drawing.Size(121, 23);
            this.listCoffeeMakers.TabIndex = 0;
            // 
            // addGrainsBtn
            // 
            this.addGrainsBtn.Location = new System.Drawing.Point(294, 76);
            this.addGrainsBtn.Name = "addGrainsBtn";
            this.addGrainsBtn.Size = new System.Drawing.Size(108, 23);
            this.addGrainsBtn.TabIndex = 1;
            this.addGrainsBtn.Text = "Add grains";
            this.addGrainsBtn.UseVisualStyleBackColor = true;
            this.addGrainsBtn.Click += new System.EventHandler(this.AddGrainsBtnClick);
            // 
            // addWaterBtn
            // 
            this.addWaterBtn.Location = new System.Drawing.Point(442, 76);
            this.addWaterBtn.Name = "addWaterBtn";
            this.addWaterBtn.Size = new System.Drawing.Size(114, 23);
            this.addWaterBtn.TabIndex = 2;
            this.addWaterBtn.Text = "Add water";
            this.addWaterBtn.UseVisualStyleBackColor = true;
            this.addWaterBtn.Click += new System.EventHandler(this.AddWaterBtnClick);
            // 
            // cleanCoffeeMachineBtn
            // 
            this.cleanCoffeeMachineBtn.Location = new System.Drawing.Point(604, 76);
            this.cleanCoffeeMachineBtn.Name = "cleanCoffeeMachineBtn";
            this.cleanCoffeeMachineBtn.Size = new System.Drawing.Size(142, 25);
            this.cleanCoffeeMachineBtn.TabIndex = 3;
            this.cleanCoffeeMachineBtn.Text = "Clear coffee machine";
            this.cleanCoffeeMachineBtn.UseVisualStyleBackColor = true;
            this.cleanCoffeeMachineBtn.Click += new System.EventHandler(this.CleanBtnClick);
            // 
            // grainsGramNumeric
            // 
            this.grainsGramNumeric.Location = new System.Drawing.Point(294, 42);
            this.grainsGramNumeric.Name = "grainsGramNumeric";
            this.grainsGramNumeric.Size = new System.Drawing.Size(120, 23);
            this.grainsGramNumeric.TabIndex = 4;
            // 
            // waterVolumeNumeric
            // 
            this.waterVolumeNumeric.Location = new System.Drawing.Point(442, 42);
            this.waterVolumeNumeric.Name = "waterVolumeNumeric";
            this.waterVolumeNumeric.Size = new System.Drawing.Size(120, 23);
            this.waterVolumeNumeric.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Water volume(ml):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grains gram:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Pollution level:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(294, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grains gram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(453, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Water volume(ml)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Coffee";
            // 
            // waterVolume
            // 
            this.waterVolume.AutoSize = true;
            this.waterVolume.Location = new System.Drawing.Point(125, 20);
            this.waterVolume.Name = "waterVolume";
            this.waterVolume.Size = new System.Drawing.Size(38, 15);
            this.waterVolume.TabIndex = 12;
            this.waterVolume.Text = "label7";
            // 
            // grainsGram
            // 
            this.grainsGram.AutoSize = true;
            this.grainsGram.Location = new System.Drawing.Point(125, 50);
            this.grainsGram.Name = "grainsGram";
            this.grainsGram.Size = new System.Drawing.Size(38, 15);
            this.grainsGram.TabIndex = 13;
            this.grainsGram.Text = "label7";
            // 
            // pollutionLevel
            // 
            this.pollutionLevel.AutoSize = true;
            this.pollutionLevel.Location = new System.Drawing.Point(125, 76);
            this.pollutionLevel.Name = "pollutionLevel";
            this.pollutionLevel.Size = new System.Drawing.Size(38, 15);
            this.pollutionLevel.TabIndex = 14;
            this.pollutionLevel.Text = "label7";
            // 
            // makeCoffeeBtn
            // 
            this.makeCoffeeBtn.Location = new System.Drawing.Point(204, 337);
            this.makeCoffeeBtn.Name = "makeCoffeeBtn";
            this.makeCoffeeBtn.Size = new System.Drawing.Size(106, 23);
            this.makeCoffeeBtn.TabIndex = 15;
            this.makeCoffeeBtn.Text = "Make coffee";
            this.makeCoffeeBtn.UseVisualStyleBackColor = true;
            this.makeCoffeeBtn.Click += new System.EventHandler(this.MakeCoffeeBtnClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Mug volume(ml)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Strength coffee";
            // 
            // mugVolumeList
            // 
            this.mugVolumeList.FormattingEnabled = true;
            this.mugVolumeList.Location = new System.Drawing.Point(204, 235);
            this.mugVolumeList.Name = "mugVolumeList";
            this.mugVolumeList.Size = new System.Drawing.Size(75, 23);
            this.mugVolumeList.TabIndex = 18;
            // 
            // strengthCoffeeList
            // 
            this.strengthCoffeeList.FormattingEnabled = true;
            this.strengthCoffeeList.Location = new System.Drawing.Point(364, 235);
            this.strengthCoffeeList.Name = "strengthCoffeeList";
            this.strengthCoffeeList.Size = new System.Drawing.Size(121, 23);
            this.strengthCoffeeList.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.strengthCoffeeList);
            this.Controls.Add(this.mugVolumeList);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.makeCoffeeBtn);
            this.Controls.Add(this.pollutionLevel);
            this.Controls.Add(this.grainsGram);
            this.Controls.Add(this.waterVolume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waterVolumeNumeric);
            this.Controls.Add(this.grainsGramNumeric);
            this.Controls.Add(this.cleanCoffeeMachineBtn);
            this.Controls.Add(this.addWaterBtn);
            this.Controls.Add(this.addGrainsBtn);
            this.Controls.Add(this.listCoffeeMakers);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grainsGramNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterVolumeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox listCoffeeMakers;
        private Button addGrainsBtn;
        private Button addWaterBtn;
        private Button cleanCoffeeMachineBtn;
        private NumericUpDown grainsGramNumeric;
        private NumericUpDown waterVolumeNumeric;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label waterVolume;
        private Label grainsGram;
        private Label pollutionLevel;
        private Button makeCoffeeBtn;
        private Label label7;
        private Label label8;
        private ComboBox mugVolumeList;
        private ComboBox strengthCoffeeList;
    }
}