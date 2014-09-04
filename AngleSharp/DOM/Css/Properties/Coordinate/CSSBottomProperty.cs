﻿namespace AngleSharp.DOM.Css.Properties
{
    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/bottom
    /// </summary>
    sealed class CSSBottomProperty : CSSCoordinateProperty, ICssBottomProperty
    {
        #region ctor

        internal CSSBottomProperty()
            : base(PropertyNames.Bottom)
        {
        }

        #endregion
    }
}
