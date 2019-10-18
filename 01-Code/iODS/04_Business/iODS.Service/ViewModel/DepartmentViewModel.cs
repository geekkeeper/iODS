using System.ComponentModel.DataAnnotations;

namespace iODS.Service.ViewModel
{
    
    public class DepartmentViewModel:BaseViewModel
    {
        [Display(Name = "部门名称")]
        [Required(ErrorMessage = "{0}是必填项}")]
        [StringLength(10,MinimumLength = 2,ErrorMessage = "{0}的长度应该不小于{2}, 不大于{1}")]
        public string Name { set; get; }
        
    }
}