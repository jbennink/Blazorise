﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public partial class Heading : BaseComponent
    {
        #region Members

        private HeadingSize headingSize = HeadingSize.Is3;

        private TextColor textColor = TextColor.None;

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.HeadingSize( headingSize ) );
            builder.Append( ClassProvider.HeadingTextColor( TextColor ), TextColor != TextColor.None );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        [Parameter]
        public HeadingSize Size
        {
            get => headingSize;
            set
            {
                headingSize = value;

                DirtyClasses();
            }
        }

        [Parameter]
        public TextColor TextColor
        {
            get => textColor;
            set
            {
                textColor = value;

                DirtyClasses();
            }
        }

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}
