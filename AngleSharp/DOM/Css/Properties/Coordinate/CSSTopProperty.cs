﻿namespace AngleSharp.DOM.Css.Properties
{
    /// <summary>
    /// Information can be found on MDN:
    /// https://developer.mozilla.org/en-US/docs/Web/CSS/top
    /// </summary>
    sealed class CSSTopProperty : CSSCoordinateProperty, ICssTopProperty
    {
        #region ctor

        internal CSSTopProperty()
            : base(PropertyNames.Top)
        {
        }

        #endregion
    }
}
