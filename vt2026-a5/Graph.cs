using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace vt2026_a4
{
    internal class Graph : Panel
    {
        private static Color[] colors = { Color.DarkCyan, Color.BlueViolet, Color.Green, Color.Lime, Color.Blue, Color.Brown, Color.DarkMagenta, Color.Crimson, Color.DarkGreen, Color.DarkOrange, Color.DarkSalmon, Color.DimGray, Color.DarkGray, Color.Azure, Color.DarkOliveGreen, Color.ForestGreen };
        private int colorindex;
        private float zoom;
        private List<List<string>> data;//format for List<string> is {id,value,time,value,time...} aggrigate all with same id 
        private List<Panel> points;
        private Size size;
        private DateTimePicker? dtp;
        private CheckBox? applyDtpCbx;

        /// <summary>
        /// dataset format []={id,value,time} , additional datasets can be added trhough method
        /// controlsize is the size of the controll set it like this instead of using the property
        /// zoom multipliess the y value, good to enlarge small changes or "zoom out" when dealing with larger ones
        /// </summary>
        /// <param name="dataset"></param>
        /// <param name="controlSize"></param>
        /// <param name="zoom"></param>
        internal Graph(List<string[]> dataset, Size controlSize, float zoom)
        {
            size = controlSize;
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = zoom;
            this.dtp = null;
            this.applyDtpCbx = null;
            colorindex = 0;
            data = new();
            points = new();
            ApplyDataset(dataset);
        }
        internal Graph(List<string[]> dataset, Size controlSize, float zoom, DateTimePicker dtp, CheckBox cbx) //for search gievn uperbound date
        {
            size = controlSize;
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = zoom;
            this.dtp = dtp;
            this.applyDtpCbx = cbx;
            colorindex = 0;
            data = new();
            points = new();
            ApplyDataset(dataset);
        }
        internal Graph(List<string[]> dataset, Size controlSize)
        {
            size = controlSize;
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = 1;
            this.dtp = null;
            this.applyDtpCbx = null;
            colorindex = 0;
            data = new();
            points = new();
            ApplyDataset(dataset);
        }
        internal Graph(Size controlSize, float zoom, DateTimePicker dtp, CheckBox cbx)
        {
            size = controlSize;
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = zoom;
            this.dtp = dtp;
            this.applyDtpCbx = cbx;
            colorindex = 0;
            data = new();
            points = new();
        }
        internal Graph(Size controlSize, float zoom)
        {
            size = controlSize;
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = zoom;
            this.dtp = null;
            this.applyDtpCbx = null;
            colorindex = 0;
            data = new();
            points = new();
        }


        internal Graph(float zoom)
        {
            size = new(500, 400);
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = zoom;
            this.dtp = null;
            this.applyDtpCbx = null;
            colorindex = 0;
            data = new();
            points = new();
        }
        internal Graph(Size controlSize)
        {
            size = controlSize;
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = 1;
            this.dtp = null;
            this.applyDtpCbx = null;
            colorindex = 0;
            data = new();
            points = new();
        }
        internal Graph()
        {
            size = new(500, 400);
            this.Height = size.Height;
            this.Width = size.Width;
            this.zoom = 1;
            this.dtp = null;
            this.applyDtpCbx = null;
            colorindex = 0;
            data = new();
            points = new();
        }
        internal void ApplyDataset(List<string[]> dataset)
        {
            Sortdata(dataset);
            HandelPoints();
        }
        internal void ApplyDataset(List<string[]> dataset, int i)
        {
            Sortdata(dataset);
            RefreshPoints(i);
        }
        internal void RefreshPoints()
        {
            DeletePoints();
            HandelPoints();
        }
        internal void RefreshPoints(int i)
        {
            DeletePoints();
            HandelPoints(i);
        }

        internal void DeletePoints()
        {
            for (int i = 0; points.Count > 0;)
            {
                points[i].Hide();
                points[i].Dispose();
                points.RemoveAt(i);
            }
            points = new();
        }

        private void HandelPoints()
        {
            foreach (List<string> l in data)
            {
                MakePoints(l);
            }
            foreach (Panel p in points)
            {
                parentAndShowPoint(p);
            }
        }
        private void HandelPoints(int i)
        {
            MakePoints(data[i]);

            foreach (Panel p in points)
            {
                parentAndShowPoint(p);
            }
        }

        private void Sortdata(List<string[]> dataset)
        {
            bool found;
            foreach (string[] s1 in dataset)
            {
                found = false;
                foreach (List<string> s2 in data)
                {
                    if (s1[0] == s2[0])
                    {
                        found = true;
                        s2.Add(s1[1]);
                        s2.Add(FormatTime(s1[2]));
                        break;
                    }
                }
                if (!found)
                {
                    List<string> newcategory = new();
                    newcategory.Add(s1[0]);
                    newcategory.Add(s1[1]);
                    newcategory.Add(FormatTime(s1[2]));
                    data.Add(newcategory);
                }
            }
        }
        /// <summary>
        /// time is handdeled backwards, to avoid the 2000 years long whatevr every timestep is 
        /// messured agaisnt the current time, point 0 is right now and -10 000 wass that many ticks ago
        /// </summary>
        /// <param name="s1"></param>
        /// <returns></returns>
        private string FormatTime(string s1)
        {
            TimeSpan dt;
            if (applyDtpCbx != null && applyDtpCbx.Checked && dtp != null)
            { dt = dtp.Value - DateTime.Parse(s1); }
            else { dt = DateTime.Now - DateTime.Parse(s1); }
            return dt.TotalSeconds.ToString();
        }

        private void MakePoints(List<string> list)
        {
            Color color = colors[colorindex++];
            Panel? previous = null;
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 2 == 0) { continue; }


                int x = (int)(float.Parse(list[i + 1]) / 10),
                    y = (int)(float.Parse(list[i]) * zoom);
                if (x > size.Width||x<0) { continue; }
                Panel p = new()
                {
                    BackColor = color,
                    Width = 4,
                    Height = 3,
                    Location = new Point(size.Width - x, size.Height - (y + 10))
                };
                points.Add(p);
                if (previous != null) //curve smoothing enterpulation 
                {
                    int dify = Math.Abs(previous.Location.Y - p.Location.Y) - (p.Height),
                        newx = ((previous.Location.X + p.Location.X) / 2),
                        newy = ((previous.Location.Y + p.Location.Y) / 2) - dify / 2;
                    points.Add(new() { BackColor = color, Width = 2, Height = dify, Location = new(newx, newy) }); //same thing as abovve but trunkated into one line
                }

                previous = p;

            }
        }

        private void parentAndShowPoint(Panel p)
        {
            p.Parent = this;
            p.Show();
        }
    }
}
