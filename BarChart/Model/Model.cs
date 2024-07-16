using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    public class Model
    {
        public string Purpose { get; set; }
        public double Percentage { get; set; }
        public Model(string purpose,double percentage)
        {
            Purpose = purpose;
            Percentage = percentage;
        }

    }
}
