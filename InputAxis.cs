﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Curvature
{
    public class InputAxis : IUserEditable
    {
        public enum OriginType
        {
            PropertyOfSelf,
            PropertyOfTarget,
            ComputedValue
        }

        public string ReadableName;
        public OriginType Origin;
        public List<InputParameter> Parameters;

        [XmlIgnore]
        public KnowledgeBase.Record KBRecord;


        internal InputAxis()
        {
        }

        public InputAxis(string name, OriginType origin)
        {
            ReadableName = name;
            Origin = origin;
            Parameters = new List<InputParameter>();
        }

        public override string ToString()
        {
            return ReadableName;
        }

        public Control CreateEditorUI(Project project)
        {
            return new EditWidgetInputAxis(project, this);
        }
    }
}
