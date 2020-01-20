using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodilityExercises.Lessons.Exam._3
{
    public partial class Solution : Component
    {
        public Solution()
        {
            InitializeComponent();
        }

        public Solution(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
