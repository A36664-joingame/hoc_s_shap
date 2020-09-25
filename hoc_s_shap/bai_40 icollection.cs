using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace hoc_s_shap
{
    #region định nghĩa icolection
    /*ICollection là 1 interface có ý nghĩa “xác định kích thước, 
     * enumerator (bộ liệt kê) và những phương thức đồng bộ cho những tập hợp không phải kiểu generic” 
     * hay nói ngắn gọn đây là 1 interface thể hiện tính chất của 1 collection
     */
    #endregion
    #region các phương thức của icollection
    /*Count: trả về số lượng phần tử của tập hợp.
      IsSynchronized và SyncRoot: 2 property để làm cho thao tác đa luồng với tập hợp an toàn hơn.
      CopyTo(Array array, int index): phương thức thực hiện copy tập hợp ra 1 mảng, bắt đầu từ vị trí index trong tập hợp.
      GetEnumerator(): Trả về 1 đối tượng kiểu IEnumerator (sẽ được trình bày trong bài IENUMERABLE VÀ IENUMERATOR TRONG C#)
     */
    #endregion
    class bai_40_icollection:ICollection
    { // interface thể hiện tính chất của collection
        
    }
}
