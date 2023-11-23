using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class Scope
    {
        public static void MeasureQueryRuntime()
        {
            MeasureQuery.LocalLineArrayList = new ArrayList();

            MeasureQuery.GlobalLineArrayList = new ArrayList();

            MeasureQuery.ScopefileArrayList = new ArrayList();

            MeasureQuery.ElementArrayList = new ArrayList();

            MeasureQuery.HostLocallineArrayList = new ArrayList();

            return;
        }
    }
}