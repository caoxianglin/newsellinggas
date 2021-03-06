﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workflow
{
    //转移线
    class Transfer
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        //转移线开始
        private Activity start;
        public Activity Start
        {
            get { return start; }
            set
            {
                if (this.start != value)
                {
                    this.start = value;
                    OnPropertyChanged("Start");
                }
            }
        }
        //转移线结束
        private Activity end;
        public Activity End
        {
            get { return end; }
            set
            {
                if (this.end != value)
                {
                    this.end = value;
                    OnPropertyChanged("End");
                }
            }
        }

        public Transfer(Activity start, Activity end)
        {
            this.start = start;
            this.end = end;
        }
    }
}
