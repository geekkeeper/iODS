using DatabaseUpdate.Annotation.Common;

namespace DatabaseUpdate.Model
{
    public class DatabaseModel
    {
        [UsedName("a")]
        [UsedName("B")]
        [UsedName("C")]
        [UsingName("HiODSDB")]
        public string DatabaseName { set; get; }
    }
}