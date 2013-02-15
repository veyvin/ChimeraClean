﻿namespace FlythroughLib.Panels {
    partial class FlythroughPanel {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.playButton = new System.Windows.Forms.Button();
            this.saveSequenceDialog = new System.Windows.Forms.SaveFileDialog();
            this.eventsList = new System.Windows.Forms.ListBox();
            this.eventsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveToEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookAtEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.playButton.Location = new System.Drawing.Point(129, 322);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(376, 23);
            this.playButton.TabIndex = 8;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // eventsList
            // 
            this.eventsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.eventsList.ContextMenuStrip = this.eventsContextMenu;
            this.eventsList.FormattingEnabled = true;
            this.eventsList.Location = new System.Drawing.Point(3, 3);
            this.eventsList.Name = "eventsList";
            this.eventsList.Size = new System.Drawing.Size(120, 342);
            this.eventsList.TabIndex = 9;
            this.eventsList.SelectedValueChanged += new System.EventHandler(this.eventsList_SelectedValueChanged);
            // 
            // eventsContextMenu
            // 
            this.eventsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.moveUpToolStripMenuItem,
            this.moveDownToolStripMenuItem});
            this.eventsContextMenu.Name = "eventsContextMenu";
            this.eventsContextMenu.Size = new System.Drawing.Size(153, 92);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToEventToolStripMenuItem,
            this.rotateToEventToolStripMenuItem,
            this.lookAtEventToolStripMenuItem,
            this.comboEventToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // comboEventToolStripMenuItem
            // 
            this.comboEventToolStripMenuItem.Name = "comboEventToolStripMenuItem";
            this.comboEventToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.comboEventToolStripMenuItem.Text = "Combo Event";
            this.comboEventToolStripMenuItem.Click += new System.EventHandler(this.comboEventToolStripMenuItem_Click);
            // 
            // rotateToEventToolStripMenuItem
            // 
            this.rotateToEventToolStripMenuItem.Name = "rotateToEventToolStripMenuItem";
            this.rotateToEventToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.rotateToEventToolStripMenuItem.Text = "Rotate To Event";
            this.rotateToEventToolStripMenuItem.Click += new System.EventHandler(this.rotateToEventToolStripMenuItem_Click);
            // 
            // moveToEventToolStripMenuItem
            // 
            this.moveToEventToolStripMenuItem.Name = "moveToEventToolStripMenuItem";
            this.moveToEventToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.moveToEventToolStripMenuItem.Text = "Move To Event";
            this.moveToEventToolStripMenuItem.Click += new System.EventHandler(this.moveToEventToolStripMenuItem_Click);
            // 
            // lookAtEventToolStripMenuItem
            // 
            this.lookAtEventToolStripMenuItem.Name = "lookAtEventToolStripMenuItem";
            this.lookAtEventToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.lookAtEventToolStripMenuItem.Text = "Look At Event";
            this.lookAtEventToolStripMenuItem.Click += new System.EventHandler(this.lookAtEventToolStripMenuItem_Click);
            // 
            // moveUpToolStripMenuItem
            // 
            this.moveUpToolStripMenuItem.Name = "moveUpToolStripMenuItem";
            this.moveUpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveUpToolStripMenuItem.Text = "Move Up";
            // 
            // moveDownToolStripMenuItem
            // 
            this.moveDownToolStripMenuItem.Name = "moveDownToolStripMenuItem";
            this.moveDownToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.moveDownToolStripMenuItem.Text = "Move Down";
            // 
            // FlythroughPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eventsList);
            this.Controls.Add(this.playButton);
            this.Name = "FlythroughPanel";
            this.Size = new System.Drawing.Size(508, 348);
            this.eventsContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.SaveFileDialog saveSequenceDialog;
        private System.Windows.Forms.ListBox eventsList;
        private System.Windows.Forms.ContextMenuStrip eventsContextMenu;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveToEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookAtEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveDownToolStripMenuItem;
    }
}
