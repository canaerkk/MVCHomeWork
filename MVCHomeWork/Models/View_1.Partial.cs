namespace MVCHomeWork.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(View_1MetaData))]
    public partial class View_1
    {
    }
    
    public partial class View_1MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        public Nullable<int> 統計銀行數 { get; set; }
        public Nullable<int> 統計聯絡人數 { get; set; }
    }
}
