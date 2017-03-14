﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curvature
{
    public class Consideration : IUserEditable
    {
        public string ReadableName;
        public InputAxis Input;
        public ResponseCurve Curve;
        public List<InputParameter> Parameters;

        internal Consideration()
        {
        }

        public Consideration(string name)
        {
            ReadableName = name;
            Parameters = new List<InputParameter>();
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetConsideration(project, this);
        }
    }
}
