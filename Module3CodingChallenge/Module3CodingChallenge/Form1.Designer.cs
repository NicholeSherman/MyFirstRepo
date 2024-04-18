namespace Module3CodingChallenge
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
            flavor = new ComboBox();
            lblChooseFlavor = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            pet = new ComboBox();
            lblChoosePet = new Label();
            lblType = new Label();
            lblPetColor = new Label();
            lblPetDescription = new Label();
            SuspendLayout();
            // 
            // flavor
            // 
            flavor.FormattingEnabled = true;
            flavor.Items.AddRange(new object[] { "Vanilla", "Rocky Road", "Strawberry", "Carmel Collision" });
            flavor.Location = new Point(265, 64);
            flavor.Name = "flavor";
            flavor.Size = new Size(151, 28);
            flavor.TabIndex = 0;
            flavor.SelectedIndexChanged += flavor_SelectedIndexChanged;
            // 
            // lblChooseFlavor
            // 
            lblChooseFlavor.AutoSize = true;
            lblChooseFlavor.Location = new Point(38, 67);
            lblChooseFlavor.Name = "lblChooseFlavor";
            lblChooseFlavor.Size = new Size(204, 20);
            lblChooseFlavor.TabIndex = 1;
            lblChooseFlavor.Text = "Choose your ice cream flavor:";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(40, 111);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(85, 20);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(40, 153);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "Price";
            // 
            // pet
            // 
            pet.FormattingEnabled = true;
            pet.Items.AddRange(new object[] { "Angel", "Apollo", "Artemis", "Coco", "Ginger", "Hades", "Harry", "Lydia", "Momo", "Toby" });
            pet.Location = new Point(265, 241);
            pet.Name = "pet";
            pet.Size = new Size(151, 28);
            pet.TabIndex = 4;
            pet.SelectedIndexChanged += pet_SelectedIndexChanged;
            // 
            // lblChoosePet
            // 
            lblChoosePet.AutoSize = true;
            lblChoosePet.Location = new Point(38, 244);
            lblChoosePet.Name = "lblChoosePet";
            lblChoosePet.Size = new Size(96, 20);
            lblChoosePet.TabIndex = 5;
            lblChoosePet.Text = "Choose a pet";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(38, 284);
            lblType.Name = "lblType";
            lblType.Size = new Size(40, 20);
            lblType.TabIndex = 6;
            lblType.Text = "Type";
            // 
            // lblPetColor
            // 
            lblPetColor.AutoSize = true;
            lblPetColor.Location = new Point(40, 330);
            lblPetColor.Name = "lblPetColor";
            lblPetColor.Size = new Size(90, 20);
            lblPetColor.TabIndex = 7;
            lblPetColor.Text = "Breed/Color";
            // 
            // lblPetDescription
            // 
            lblPetDescription.AutoSize = true;
            lblPetDescription.Location = new Point(38, 371);
            lblPetDescription.Name = "lblPetDescription";
            lblPetDescription.Size = new Size(85, 20);
            lblPetDescription.TabIndex = 8;
            lblPetDescription.Text = "Description";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPetDescription);
            Controls.Add(lblPetColor);
            Controls.Add(lblType);
            Controls.Add(lblChoosePet);
            Controls.Add(pet);
            Controls.Add(lblPrice);
            Controls.Add(lblDescription);
            Controls.Add(lblChooseFlavor);
            Controls.Add(flavor);
            Name = "Form1";
            Text = "Ice Cream Flavors";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox flavor;
        private Label lblChooseFlavor;
        private Label lblDescription;
        private Label lblPrice;
        private ComboBox pet;
        private Label lblChoosePet;
        private Label lblType;
        private Label lblPetColor;
        private Label lblPetDescription;
    }
}
