﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace YMTEditor
{
    public class ComponentDrawable : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int _drawableIndex;
        public int drawableIndex
        {
            get { return _drawableIndex; }
            set
            {
                _drawableIndex = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("drawableIndex"));
            }
        }
        public int drawableTextureCount { get; set; }
        public int drawablePropMask { get; set; }
        public int drawableAlternatives { get; set; }
        public bool drawableHasCloth { get; set; }

        public ObservableCollection<ComponentTexture> drawableTextures { get; set; }
        public ObservableCollection<ComponentInfo> drawableInfo { get; set; }

        public ComponentDrawable(int index, int txtCount, int propMask, int numAlternatives, bool hasCloth, ObservableCollection<ComponentTexture> textureList, ObservableCollection<ComponentInfo> infoList)
        {
            drawableIndex = index;
            drawableTextureCount = txtCount;
            drawablePropMask = propMask;
            drawableAlternatives = numAlternatives;
            drawableHasCloth = hasCloth;
            drawableTextures = textureList;
            drawableInfo = infoList;
        }

        public override string ToString() //used to determine if clicked texture or drawable button (return is displayed as DataContext of button) (MainWindow.xaml.cs -> Button_Click_AddComponent)
        {
            return drawableIndex + " " + drawableTextureCount;
        }
    }
}
