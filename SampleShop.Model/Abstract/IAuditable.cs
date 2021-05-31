using System;

namespace SampleShop.Model.Abstract
{
    public interface IAuditable
    {
        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }

        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDate { get; set; }
        string UpdatedBy { get; set; }
    }
}