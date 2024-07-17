using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarChart
{
    public class ViewModel
    {
        public ObservableCollection<Model> GettingInformationDetails { get; set; }

        public ObservableCollection<Model> CreatingMediaDetails { get; set; }
        public ViewModel()
        {
            GettingInformationDetails = new ObservableCollection<Model>()
            {
                new Model("Answering factual questions",11),
                new Model("Asking advice",10),
                new Model("Generating ideas",9),
                new Model("Playing around or experimenting",9),
                new Model("Summarizing text",8),
                new Model("Seeking support",7),
                new Model("Recommendations",6),
                new Model("Translations",6),
                new Model("Getting the latest news",5),
                new Model("Data analysis",5),
                new Model("Other",1),
            };

            CreatingMediaDetails = new ObservableCollection<Model>()
            {
                new Model("Playing around or experimenting",11),
                new Model("Writing an email or letter",9),
                new Model("Making an image",9),
                new Model("Writing an essay or report",8),
                new Model("Creative writing",7),
                new Model("A job application/interview",5),
                new Model("Programming or coding",5),
                new Model("Making a video",4),
                new Model("Making audio",3),
                new Model("Creating test data",3),
                new Model("Other",2),
            };
        }
    }
}
