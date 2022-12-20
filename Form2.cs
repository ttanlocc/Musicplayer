using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Musicplayer
{
    public partial class Form2 : Form
    {
        DataTable dt_Viral = new DataTable();
        DataTable dt_Liked = new DataTable();
        DataTable dt_Vpop = new DataTable();
        DataTable dt_MyList = new DataTable();
        DataTable dt_All = new DataTable();



        public Form2()
        {
            InitializeComponent();

            dt_Viral.Columns.Add("theloai", typeof(string));
            dt_Viral.Columns.Add("hinhanh", typeof(object));
            dt_Viral.Columns.Add("liked", typeof(int));
            dt_Viral.Columns.Add("tenbaihat", typeof(string));
            dt_Viral.Columns.Add("tencasi", typeof(string));
            dt_Viral.Columns.Add("thoiluong", typeof(string));
            dt_Viral.Columns.Add("tacgia", typeof(string));
            dt_Viral.Columns.Add("baihat", typeof(string));
            dt_Viral.Columns.Add("loibaihat", typeof(string));

            dt_Vpop = dt_Viral.Clone();
            dt_Liked = dt_Viral.Clone();
            dt_MyList = dt_Viral.Clone();

            //loai - hinh - like - ten - casi - thoi luong - composer - bai hat - loi
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop1, 0, "Bên Trên Tầng Lầu", "Uyên Linh", "3:03", "Tăng Duy Tân", "D:\\Song\\song1.mp3", "Em ơi đừng khóc bóng tối trước mắt sẽ bắt em đi\r\nEm ơi đừng lo em ơi đừng cho tương lai vụt tắt.\r\nSâu trong màu mắt có chút tiếc nuối phút cuối chỉ vì\r\nEm đâu hề sai em đâu thể mãi để trái tim đau\r\n\r\nKhông còn tương lai, em cũng chẳng còn thương ai.\r\nSau bao niêm đau em mong rằng con tim em dừng lại.\r\nNỗi nhớ này lâu phai, nhốt em trong 1 lâu đài,\r\nLâu đài của những cơn đau bất tận\r\n\r\nVì sao em phải khóc?\r\nCó đáng để buồn đâu, tình yêu như cơn lốc thoáng phút chốc lướt qua thật mau.\r\nVì sao em phải khóc?\r\nCó đáng để buồn đâu, rượu kề môi em nốc, thoáng phút chốc đã vơi u sầu\r\n\r\nBuông bàn tay để chấm hết,\r\ntất cả thứ làm em buồn,\r\nbao gồm cả cuộc đời của em.\r\nEm à cho dù có khóc,\r\ncũng sẽ đến ngày phải quên,\r\nthiên đường vẫn chờ ngày em đến");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop2, 0, "Chưa Quên Người Yêu Cũ", "Hà Nhi", "5:02", "Hứa Kim Tuyền", "D:\\Song\\song2.mp3", "Cũng đã gần ba năm, mà em vẫn nhớ anh nhiều lắm\r\nVẫn chưa thể yêu ai, vẫn chưa muốn bên ai\r\nThế gian này rộng lớn mà con tim chẳng to nhiều hơn\r\nChỉ vừa đủ nhớ 1 người, chỉ vừa đủ thương 1 người...\r\nĐK:\r\nĐâu phải em muốn quên, là sẽ quên, là sẽ quên\r\nĐâu phải mong hết đau, là bớt đau, là bớt đau.\r\nNhiều khi lý trí cố gắng mạnh mẽ, nhưng trái tim thật sự yếu đuối\r\nLà em giấu đi, chỉ là em giấu đi.\r\nĐâu phải yêu hết tâm, người để tâm, người để tâm.\r\nĐâu phải cho hết đi, người chẳng đi, người chẳng đi.\r\nChỉ vì đôi khi yêu thương một ai, ta chẳng mong nhận lại chi hết\r\nNgờ đâu mấy khi, tình yêu lại khiến ta hoen bờ mi\r\n(Verse 2)\r\nNhớ khi mình *** nhau, cùng đi trên chiếc xe đạp nâu\r\nLá xanh còn chưa chín, đã hẹn ước đôi mình...\r\nƯớc muôn đời bên nhau, bàn tay nắm mãi chẳng rời đâu\r\nMột câu nói trót lỡ lời...Rồi ta mất nhau một đời...\r\nĐK:\r\nĐâu phải em muốn quên, là sẽ quên, là sẽ quên\r\nĐâu phải mong hết đau, là bớt đau, là bớt đau.\r\nNhiều khi lý trí cố gắng mạnh mẽ, nhưng trái tim thật sự yếu đuối\r\nLà em giấu đi, chỉ là em giấu đi.\r\nĐâu phải yêu hết tâm, người để tâm, người để tâm.\r\nĐâu phải cho hết đi, người chẳng đi, người chẳng đi.\r\nChỉ vì đôi khi yêu thương một ai, ta chẳng mong nhận lại chi hết\r\nVà không thể quên, cũng là một cách yêu thương gọi tên.\r\n(Bridge)\r\nChẳng phải em không thể, không thể tìm được một ai khác.\r\nChỉ là vì anh đã đi để lại khoảng không khó đầy...\r\nMột mình em vẫn tốt, vẫn tự mình dịu xoa những tổn thương\r\nChờ ngày trái tim em lại yêu và yêu nhiều hơn nữa.\r\nĐâu phải em muốn quên, là sẽ quên, là sẽ quên\r\nĐâu phải mong hết đau, là bớt đau, là bớt đau.\r\nNhiều khi lý trí cố gắng mạnh mẽ, nhưng trái tim thật sự yếu đuối\r\nLà em giấu đi, chỉ là em giấu đi.\r\nĐâu phải yêu hết tâm, người để tâm, người để tâm.\r\nĐâu phải cho hết đi, người chẳng đi, người chẳng đi.\r\nChỉ vì đôi khi yêu thương một ai, ta chẳng mong nhận lại chi hết\r\nNgờ đâu mấy khi , tình yêu lại khiến ta hoen bờ mi\r\nVà không thể quên, cũng là một cách yêu thương gọi tên.");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop3, 0, "Anh Chưa Thuong Em Đến vậy đâu", "Myra Trần", "4:20", "Hứa Kim Tuyền", "D:\\Song\\song3.mp3", "Em đi xem phim một mình giữa đêm\r\nVà đi karaoke một mình giữa đêm\r\nĐể biết em cô đơn làm sao\r\nĐể biết em nhớ anh nhường nào\r\n\r\nEm đi Seoul một mình ngắm tuyết rơi\r\nVà đi Bali một mình ngắm biển khơi\r\nĐể thấy em chơi vơi làm sao\r\nĐể thấy em yêu anh nhường nào\r\n\r\nSao mình không gạt bỏ đi hết những lời nói ngoài kia\r\nVà sao mình không gạt bỏ đi hết những định kiến ngoài kia\r\n\r\nGiữa ngân hà em biết đâu là\r\nBiết đâu là thế gian này mà\r\nMình bên nhau, được yêu nhau, được hôn nhau và trao nhau trái tim đậm sâu\r\n\r\nGiữa ngân hà em biết đâu là\r\nBiết đâu một sớm mai khi mà\r\nCần bao lâu, chờ bao lâu, đợi bao lâu, tình trao nhau mãi thôi đậm sâu\r\n\r\nSao mình không gạt bỏ đi hết những lời nói ngoài kia\r\nVà sao mình không gạt bỏ đi hết những định kiến ngoài kia\r\n\r\nGiữa ngân hà em biết đâu là\r\nBiết đâu là thế gian này mà\r\nMình bên nhau, được yêu nhau, được trao nhau, tình yêu sâu trái tim đậm sâu\r\n\r\nGiữa ngân hà em biết đâu là\r\nBiết đâu một sớm mai khi mà\r\nCần bao lâu, chờ bao lâu, đợi bao lâu, tình trao nhau mãi thôi đậm sâu\r\n\r\nGiữa ngân hà, giữa ngân hà, giữa ngân hà\r\nBiết đâu là, biết đâu là, biết đâu là\r\nHành tinh của hai chúng ta\r\nMột nơi của riêng chúng ta\r\n\r\nGiữa ngân hà, giữa ngân hà, giữa ngân hà\r\nBiết đâu là, biết đâu là, biết đâu là\r\nHành tinh của hai chúng ta\r\nỞ 1 thế giới còn rất xa\r\n\r\nAnh chưa yêu em (×3) đến vậy đâu.\r\nAnh chưa thương em (×3) đến vậy đâu\r\nVậy nên, người mới buông tay dễ dàng như thế\r\n\r\nNhưng em yêu anh (×3) rất đậm sâu\r\nNhưng em thương anh (×3) rất đậm sâu\r\nVậy nên, chẳng thể buông tay dễ dàng\r\n\r\nGiữa ngân hà, giữa ngân hà, giữa ngân hà\r\nBiết đâu là, biết đâu là, biết đâu là\r\nHành tinh của hai chúng ta\r\nMột nơi của riêng chúng ta\r\n\r\nGiữa ngân hà, giữa ngân hà, giữa ngân hà\r\nBiết đâu là, biết đâu là, biết đâu là\r\nHành tinh của hai chúng ta\r\nỞ 1 thế giới còn rất xa");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop4, 0, "Ai chung tình được mãi", "Trung Quân", "4:07", "Huy Đinh", "D:\\Song\\song4.mp3", "Bình minh ơi dậy chưa cà phê sáng với tôi được không\r\nChơi vơi qua ngày đông sao thấy cô đơn và lạc lõng\r\n\r\nĐêm ơi đã ngủ chưa ngồi đây uống với tôi vài ly\r\nSay thì cứ say, yêu thì bỏ đi\r\nĐôi khi ta gặp nhau để dạy nhau cách sống trong khổ đau\r\nĐôi chân mang lặng thinh thương một người không hề toan tính\r\nĐôi khi anh dừng lại chẳng hiểu đang khóc đang đau vì ai\r\nKhóc vì, đau vì duyên mình đã sai\r\n\r\nNhiều khi muốn một mình nhưng sợ cô đơn\r\nSợ cảm giác trống vắng mỗi ngày mỗi lớn\r\nSợ chạm vào nỗi nhớ vu vơ gian gian díu díu mập mờ\r\nNắm chưa xong đã vội đổ vỡ\r\n\r\nỪ thì anh thích một mình nhưng sợ cô đơn\r\nDù đã từng nói như thế có lẽ sẽ tốt hơn\r\nChỉ là vì chẳng muốn yêu ai khi mình anh với những đêm dài\r\nNghĩ đi em đâu ai chung tình được mãi");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop5, 0, "Cô Đơn Trên Sofa", "Hồ Ngọc Hà", "4:23", "Tăng Duy Tân", "D:\\Song\\song5.mp3", "Cô đơn trên sofa, con tim như tan ra\r\nDẫn lối em trôi theo một khúc ca buồn\r\nGiữa căn phòng, ánh đèn chợt tắt\r\nChe đi giọt buồn sắp rơi\r\n\r\nCô đơn trên sofa, sao anh yêu cô ta?\r\nChẳng phải anh yêu em hơn cả anh mà?\r\nĐể cho thanh xuân này chợt tắt\r\nTrên mi giọt nước mắt rơi\r\n\r\nThì ra là thế, tình nào là tình chẳng mờ phai tháng năm\r\nMột ngày vẫn trôi, đôi môi em phai màu nắng\r\nNếu không em thì anh có buồn?\r\nHóa ra chỉ mình em đáng thương\r\n\r\nĐừng buông lời hứa, rồi lại vờ rằng dường như anh đã quên\r\nĐừng tìm đến em, gieo tương tư xong lại đi\r\nNắng xuyên qua hàng mi rối bời\r\nGiữ tim em vài giây cuối thôi\r\n\r\nĐể em được ngã lưng lên một chiếc sofa\r\nĐể nghe một phút tim yên bình đến kỳ lạ\r\nĐể em được sống vô tư như một bông hoa, giữa bầu trời kiêu sa\r\nCho em thôi miệt mài nghĩ suy\r\n\r\nNgười ơi hãy nói em nghe một lý do đi\r\nVì sao lại để em vương sầu trên khóe mi?\r\nVì sao lại biến cô đơn thành giông tố, nỗi buồn sóng vỗ?\r\nTâm hồn em trôi lênh đênh trong căn phòng, rồi lại rơi xuống trên sofa");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop6, 0, "Người Như Anh", "Mai Tiến Dũng", "4:50", "Hùng Quân", "D:\\Song\\song6.mp3", "Và rồi hôm ấy mình rời bước, cách xa nhau\r\nDẫu hai ta chẳng giận hờn\r\nNhưng cảm giác bên nhau ngày một xa hơn\r\nLời hứa ta đã từng dành cho nhau\r\nGiờ chúng ta xếp lại ngày ngày mai sau\r\nEm khóc cho bao mộng mơ\r\nAnh khóc cuộc tình bơ vơ\r\nChúng ta, gần nhau mà như cách xa\r\nChúng ta, gần nhau mà lòng băng giá\r\nTình yêu có phải khi ta chấp nhận\r\nRời xa để thấy yêu nhau nhiều hơn?\r\nAnh mong rằng em sẽ có một người\r\nYêu em, cùng em đến hết cuộc đời\r\nMột người mới luôn khiến em vui,\r\nChẳng phải như anh chỉ làm em khóc\r\nNước mắt cho em đã quá đủ rồi\r\nNỗi xót xa em nhận lấy nhiều rồi\r\nXin lỗi anh không như những gì mà em mong\r\nMột người như anh\r\nVà anh biết, rằng nơi trái tim em còn\r\nCòn mong nhớ anh từng giờ\r\nNỗi đau anh biết rằng là, thật khó để mình quên đi\r\nVà anh cũng chẳng làm sao để xóa đi được\r\nDù đôi lúc anh bật khóc bao đêm\r\nChẳng biết bao lâu anh quên ngày mình bên nhau\r\nAnh mong rằng em sẽ có một người\r\nYêu em, cùng em đến hết cuộc đời\r\nMột người mới luôn khiến em vui,\r\nChẳng phải như anh chỉ làm em khóc\r\nNước mắt cho em đã quá đủ rồi\r\nNỗi xót xa em nhận lấy nhiều rồi\r\nXin lỗi anh không như những gì mà em mong\r\nMột người như anh");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop7, 0, "Suýt Nữa Thì...", "Andiez", "4:46", "Andiez", "D:\\Song\\song7.mp3", "Suýt nữa thì\r\nAnh có thể nói muôn vàn lời muốn nói\r\nSuýt nữa thì\r\nCó thể đèo em, qua từng hàng phố ***\r\nDòng lưu bút năm xưa viết vội\r\nHay còn nhớ nhau đến những ngày sau\r\nTình yêu đầu tiên anh giữ, vẫn vẹn nguyên nơi con tim này\r\nAnh còn nhớ\r\nMỗi lúc tan trường ngại ngùng theo em\r\nLà con phố, có hoa bay anh mãi theo sau\r\nKhoảng cách ấy mà sao xa quá\r\nChẳng thể nào để tới bên em\r\nThời thanh xuân anh đang có là những nỗi buồn nuối tiếc\r\nLời chưa nói\r\nAnh thả vào trong cơn gió nhắn với mây trời\r\nTình yêu đó\r\nChỉ riêng anh biết anh cũng chẳng mong hơn nhiều\r\nLiệu rằng em còn ai đưa đón\r\nAnh ơ thờ dõi theo em\r\nNếu có thể trở về hôm ấy\r\nAnh sẽ chẳng để phí cơ hội\r\nTừng vòng quay trên chiếc xe đạp anh đón đưa em ngang qua\r\nThời thanh xuân, mà ta cùng nhau viết lên những giấc mơ đẹp\r\nMột buổi chiều ngập tràn mảnh vỡ\r\nRơi ra từ hạnh phúc riêng anh\r\nSuýt nữa thì người đã biết\r\nYêu thương 1 thời anh đã tương tư");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop8, 0, "Anh Tự Do Nhưng Cô Đơn", "Trung Quân", "5:15", "Đạt G", "D:\\Song\\song8.mp3", "Đau mấy lần rồi\r\nThật sự đau rất nhiều lần\r\nNhắc đến là buồn\r\nMà chẳng hiểu là tại sao\r\nTại vì sau bao vấp ngã\r\nAnh mạnh mẽ nhưng anh không cười\r\nNhìn dòng xe qua vội vã\r\nAnh lặng lẽ chầm chậm tay ga\r\nMưa bão ùa về\r\nLà ngày em chẳng trở về\r\nQua mấy cuộc tình\r\nGiờ vẫn thế một mình đơn côi\r\nTình đầu mang bao lừa dối\r\nNên sợ lắm khi ai thề\r\nNhìn tự do không giờ giấc\r\nNhưng thực tế thì lại cô đơn\r\nVậy anh là ai thế em\r\nEm à, em ơi\r\nMồ côi tình yêu như thế\r\nSao không đi tìm\r\nEm muốn gì, cần gì ở anh\r\nAnh chỉ còn một con tim nát tan\r\nVậy anh là ai, là ai\r\nLà ai thế em\r\nVì anh là mưa\r\nVướng chân em về trong khuya\r\nBuồn kia hoà theo tiếng hát\r\nAnh ôm thêm sầu\r\nNghe tiếng lòng mình đang thở than\r\nKhông biết bầu trời kia sớm tối\r\nMột chút vỡ nát\r\nKèm theo một ít cô đơn\r\nCũng đủ rồi");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop9, 0, "906090", "Tóc Tiên", "3:28", "Mew Amazing", "D:\\Song\\song9.mp3", "Em chính thức thua rồi\r\nTrong cuộc đua tình ái này\r\nAnh là kẻ hay bày trò chơi\r\nBắt em phải theo\r\nBởi vì yêu anh quá nên ngốc nghếch theo\r\n\r\nAnh muốn gì cũng được\r\nAnh thích gì cũng chiều\r\nDù điều anh muốn rất chi hoang đường\r\nDù điều anh mong rất là vô lý\r\n\r\n90 60 90\r\nTóc mướt mát gót chân lung linh hồng hào trắng tươi\r\n90 60 90\r\nPhải làm sao cho mười phân vẹn mười\r\n90 60 90\r\nHay em sắm cho anh búp bê với ba vòng đều khỏi chê\r\nPhải chăng con người mải mê\r\nNhững mong muốn ham muốn ôi thật tệ ... hại\r\n\r\nYou say what?\r\nOh i’m done\r\n(x4)");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop10, 0, "Nàng Thơ", "Hoàng Dũng", "4:14", "Hoàng Dũng", "D:\\Song\\song10.mp3", "Em, ngày em đánh rơi nụ cười vào anh\r\nCó nghĩ sau này em sẽ chờ\r\nVà vô tư cho đi hết những ngây thơ\r\nAnh, một người hát mãi những điều mong manh\r\nLang thang tìm niềm vui đã lỡ\r\nChẳng buồn dặn lòng quên hết những chơ vơ\r\n\r\nTa yêu nhau bằng nỗi nhớ chưa khô trên những bức thư\r\nTa đâu bao giờ có lỗi khi không nghe tim chối từ\r\nChỉ tiếc rằng\r\n\r\nEm không là nàng thơ\r\nAnh cũng không còn là nhạc sĩ mộng mơ\r\nTình này nhẹ như gió\r\nLại trĩu lên tim ta những vết hằn\r\nTiếng yêu này mỏng manh\r\nGiờ tan vỡ, thôi cũng đành\r\nXếp riêng những ngày tháng hồn nhiên\r\nTrả lại...\r\n\r\nMai, rồi em sẽ quên ngày mình khờ dại\r\nMong em kỷ niệm này cất lại\r\nMong em ngày buồn thôi ướt đẫm trên vai\r\nMai, ngày em sải bước bên đời thênh thang\r\nChỉ cần một điều em hãy nhớ\r\n\r\nCó một người từng yêu em tha thiết vô bờ\r\n\r\nEm không là nàng thơ\r\nAnh cũng không còn là nhạc sĩ mộng mơ\r\nTình này nhẹ như gió\r\nLại trĩu lên tim ta những vết hằn\r\nTiếng yêu này mỏng manh\r\nGiờ tan vỡ, thôi cũng đành\r\nXếp riêng những ngày tháng hồn nhiên\r\nTrả hết cho em");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop11, 0, "Vaicaunoicokhiennguoithaydoi", "GREY D", "3:45", "GREY D", "D:\\Song\\song11.mp3", "Thức thâu đêm để nghĩ suy về em nhiều\r\nThật ra có những điều làm cho anh\r\nKhông yên được giấc\r\nBấy lâu ta không nói nhau một câu nào\r\nChờ dòng tin nhắn chào\r\nTrở lại cảm giác như lúc trước\r\n\r\nCó phải vì anh vẫn thường vô ý\r\nChẳng suy nghĩ, vài lần khiến em u sầu\r\nCó phải vì anh trót vài câu nói\r\nChạm vào nơi niềm đau\r\nmà người luôn chôn giấu\r\n\r\n[Chorus]\r\nVài câu nói có khiến người thay đổi\r\nCó khiến bờ môi ấm êm\r\nNay chỉ còn trong nỗi nhớ\r\nVài câu nói kéo đến màu u tối\r\nCuốn hết bình yên lúc xưa bên cạnh nhau\r\nMãi đi xa để mình ta trong căn phòng\r\ncùng nước mắt trong lòng");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop12, 0, "Gửi Người Yêu Cũ", "Hồ Ngọc Hà", "4:43", "Nguyễn Hồng Thuận", "D:\\Song\\song12.mp3", "Người hỏi: \"Sau khi chia tay em sống vui hay đang buồn?\"\r\nRồi làm như anh lo lắng, anh quan tâm.\r\nVà hỏi: \"Sau khi chia tay em đã yêu thêm một người khác?\"\r\nRồi thản nhiên, sao có thể không biết là.\r\n\r\nEm học yêu bản thân hơn, em học *** với cô đơn,\r\nCố quên một điều mà em ngỡ là mãi mãi.\r\nAnh tàn nhẫn bỏ em đi, không màng đến chút nghĩ suy,\r\nĐể em ở lại nhìn đâu cũng đau.\r\n\r\nVì em yếu đuối,\r\nMuôn đời em vẫn yếu đuối,\r\nEm che hết đi bằng những gượng cười.\r\nChẳng để ai nhận ra rằng em yếu đuối,\r\nMuôn đời em vẫn yếu đuối.\r\nAnh không phải em đâu thể hiểu được:\r\nNếu như không mạnh mẽ em biết phải thế nào?");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop13, 0, "Chân Ái", "Orange, Khói, Châu Đăng Khoa", "4:22", "Châu Đăng Khoa", "D:\\Song\\song13.mp3", "Tự dưng buồn thế\r\nTự dưng lặng lẽ\r\nTự dưng nhỏ bé\r\nTự dưng cần có ai vỗ về\r\n\r\nTự dưng mỏng manh\r\nTự dưng cảm lạnh\r\nTự dưng nhìn quanh\r\nTự dưng cần có ai bên cạnh\r\n\r\nAAAAAAAAAAAAAA\r\nAAAAAAAAAAAAAA\r\nYêu nhau thôi đừng hứa xa xôi!\r\nAAAAAAAAAAAAAA\r\nAAAAAAAAAAAAAA\r\nYêu nhau đi còn đắn đo gì ?!\r\n\r\n[RAP:]\r\n1. Yêu em như một thói *** thi vị\r\nYêu em vì anh chỉ muốn cho đi\r\nYêu em mọi người đều “ồ có lí”\r\nYêu em cũng dễ thôi mà nào đâu khó gì?\r\n\r\nYêu em để nhắc nhở mình từng vỡ tan\r\nYêu em tưởng nhớ vài cuộc tình dở dang\r\nYêu em như thể đây là giấc mơ vàng\r\nYêu em tới nỗi... buồn anh cũng đem ra mở bán\r\nAnh biết\r\nTấm duyên tình vẫn thường vỡ đôi\r\nBài chuyện còn cần gỡ rối\r\nBài điều chân thành không may lỡ thời\r\nNên việc gặp em chắc chỉ là mơ thôi\r\nVì anh tầm tã trong cơn mưa kí ức\r\nSợ lại đâu vào đấy vào một ngày cũng phai phôi\r\nCho niềm đau là điều yêu quý nhất\r\nNên cơ hội có tới vẫn băn khoăn không nỡ đổi, em ơi!");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop14, 0, "Muộn Rồi Mà Sao Còn", "Sơn Tùng M-TP", "5:09", "Nguyễn Thanh Tùng", "D:\\Song\\song14.mp3", "Muộn rồi mà sao còn nhìn lên trần nhà rồi quay ra lại quay vào\r\nNằm trằn trọc vậy đến sáng mai\r\nÔm tương tư, nụ cười của ai đó\r\nLàm con tim ngô nghê như muốn khóc òa\r\nVắt tay lên trên trán mơ mộng\r\nĐược đứng bên em trong nắng xuân hồng\r\n1 giờ sáng trôi qua trôi nhanh kéo theo ưu phiền miên man\r\nÂm thầm gieo tên em vẽ lên hi vọng\r\nĐúng là yêu thật rồi còn không thì hơi phí này cứ thế loanh quanh loanh\r\nQuanh loanh quanh lật qua lật lại (2 giờ)\r\nNhững ngôi sao trên cao là người bạn tâm giao\r\nLắng nghe anh luyên thuyên về một tình đầu đẹp tựa chiêm bao\r\nCó nghe thôi đã thấy ngọt ngào\r\nĐủ biết anh si mê em nhường nào\r\nÍt khi văn thơ anh dạt dào bụng đói nhưng vui quên luôn cồn cào\r\nNắm đôi tay kiêu sa được một lần không ta\r\nNghĩ qua thôi con tim trong anh đập tung lên rung nóc rung nhà\r\nHóa ra yêu đơn phương một người\r\nHóa ra khi tơ vương một người 3 giờ đêm vẫn ngồi cười\r\n\r\nCứ ôm anh đi ôm anh đi ôm anh đi ôm anh đi\r\nÔm trong cơn mơ trong cơn mơ trong cơn mơ trong cơn mơ\r\nCó thế cũng khiến anh vui điên lên ngỡ như em đang bên\r\nChắp bút đôi ba câu thơ ngọt ngào muốn em đặt tên\r\nCứ ôm anh đi ôm anh đi ôm anh đi ôm anh đi\r\nÔm trong giấc mơ trong cơn mơ trong cơn mơ trong cơn mơ\r\nYêu đến vậy thôi phát điên rồi làm sao giờ");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop15, 0, "Trên Tình Bạn Dưới Tình Yêu", "MIN", "4:27", "Khắc Hưng", "D:\\Song\\song15.mp3", "Ta biết nhau từ lâu rồi\r\nTa hiểu từng thói quen của nhau\r\nTuy không phải người yêu với nhau\r\nTa vẫn hơn là bạn\r\n\r\nTa biết nhau luôn nghĩ gì\r\nKhông cần phải nói ra làm chi\r\nCâu chuyện này cứ như vậy đi\r\nVẫn tiếc thêm làm gì\r\n\r\nMình bên nhau giống như người yêu\r\nNhìn nhau giống như người yêu\r\nDù không phải là tình yêu\r\nNhưng chắc chắn không phải tình bạn\r\n\r\nDù có lẽ sẽ không dài lâu\r\nNhưng ta sẽ thật đậm sâu\r\nMối tình này không cần định nghĩa gì đâu\r\n\r\n[ĐK:]\r\nĐôi ta ở trên tình bạn, ở dưới tình yêu\r\nĐược vui biết bao nhiêu khi có người nuông chiều\r\nĐôi ta ở trên tình bạn, ở dưới tình yêu\r\nĐược vui biết bao nhiêu khi có người thấu hiểu\r\n\r\nKhông phải người yêu mà vui hơn rất nhiều\r\nYah\r\nKhông phải người yêu mà vui hơn rất nhiều\r\nYah\r\nKhông phải người yêu mà vui hơn rất nhiều\r\nYah\r\nRất nhiều Rất nhiều Rất nhiều");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop16, 0, "See Tình", "Hoàng Thùy Linh", "3:40", "DTAP", "D:\\Song\\song16.mp3", "Uầy uầy uây uây\r\nSao mới gặp lần đầu mà đầu mình quay quay\r\nAnh ơi anh à\r\nAnh bỏ bùa gì mà lại làm em yêu vậy?\r\nBae bae bae bae\r\nEm nói từ đầu baby can you stay\r\nMai đi coi ngày\r\nXem cưới ngày nào thì nhà mình đông con vậy?\r\n\r\n[Pre-chorus 1]\r\nNếu như một câu nói có thể khiến anh vui\r\nSẽ suốt ngày luôn nói không ngừng để anh cười\r\nNếu em làm như thế trông em có hâm không?\r\nĐem ngay vô nhà thương, đem ngay vô nhà thương\r\nĐem ngay vô nhà anh để thương!\r\n\r\n[Chorus]\r\nGiây phút em gặp anh là\r\nEm biết em see tình\r\nTình tình tình tang tang tính\r\nTang tình tình tình tang tang tang\r\n\r\nGiây phút em gặp anh là\r\nEm biết em see tình\r\nTình đừng tình toan toan tính\r\nToang tình mình tình tan tan tan tình");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop17, 0, "Phải Chăng Em Đã Yêu?", "Juky San, REDT", "3:10", "REDT", "D:\\Song\\song17.mp3", "Phải chăng em đã yêu ngay từ cái nhìn đầu tiên\r\nPhải chăng em đã say ngay từ lúc thấy nụ cười ấy\r\nTình yêu ta ngất ngây, xây được chín tầng trời mây, khuất xa mờ\r\nÁnh lên từng giấc mơ ngày có anh.\r\n\r\nCuộc đời em vốn, chỉ là đường thẳng mà thôi\r\nMà sao tình cờ gặp anh, em rẽ ngang qua đời\r\nVài người vội vã, vội đến rồi đi\r\nMà sao em yêu anh đâu cần nghĩ suy\r\n\r\nTừng đêm nhớ mong về người\r\nBiết anh còn chờ đợi\r\nChơi vơi bao đêm em thấy đủ rồi\r\n\r\nNgàn tia nắng anh gần lại\r\nÁnh dương màu mắt xanh ngời\r\nLóe lên ngàn giấc mơ còn trong đời\r\n\r\n[ĐK:]\r\nPhải chăng em đã yêu ngay từ cái nhìn đầu tiên\r\nPhải chăng em đã say ngay từ lúc thấy nụ cười ấy\r\nTình yêu ta ngất ngây, xây được chín tầng trời mây, khuất xa mờ\r\nÁnh lên từng giấc mơ ngày có anh.\r\n\r\nTrái đất vốn lạ thường\r\nMà sao em cứ đi nhầm đường\r\nLạc vào tim anh lẻ loi\r\nĐằng sau chữ yêu đây là thương\r\n\r\nWhen you call me a baby\r\nMake me so crazy\r\nMy heart is breaking slowly\r\nChầm chậm bờ môi khẽ trôi\r\nÔi mình yêu thật rồi");
            dt_Vpop.Rows.Add("VPOP", Properties.Resources.vpop18, 0, "Cô Gái m52", "HuyR, Tùng Viu", "4:52", "HuyR, Tùng Viu", "D:\\Song\\song18.mp3", "Là cô gái hay mộng mơ\r\nXinh đẹp như tiên giáng trần\r\nNgười đã khiến tôi thẫn thờ\r\nCho ngày qua tôi thẫn thờ\r\nCho tôi nhung nhớ bao nhiêu\r\nMuốn nói với em bao điều rằng tôi đã thương em nhiều\r\nYêu em từ lâu em biết chăng\r\n\r\nChẳng giống mấy cô người mẫu\r\nEm đẹp xinh cô gái Việt\r\nChẳng son phấn tô sắc màu\r\nEm giản dị theo cách riêng\r\nChỉ cao 1m52\r\nNhưng sao đáng yêu dịu dàng đôi môi thắm duyên nụ cười\r\nCho tôi say tôi mơ từng đêm nhớ mong\r\n\r\nThôi thì là duyên nếu người thuận thì tôi\r\nSang thưa chuyện mẹ cha, xin được nên vợ chồng\r\nThương em để lâu hóa thêm âu sầu\r\nNay nói ra cho hết đau đầu\r\n\r\nRồi ta sẽ thật hạnh phúc\r\nBên nhau bên nhau chẳng rời\r\nCùng nhau sống chung mái nhà\r\nTa say bên nhau suốt đời\r\nCho nhau chén nước chén cơm\r\nCho nhau chút duyên chút tình nụ cười tươi nở trên môi\r\nĐa đa đa đá đa đa đa đà");


            //loai - hinh - like - ten - casi - thoi luong - composer - bai hat - loi

            dt_Viral.Rows.Add("VIR", Properties.Resources.img1, 0, "Watting for you", "Mono", "4:25", "Hoàng Anh, Việt Hoàng", "D:\\Song\\1 Waiting For You.mp3", "Chiều đang dần buông hạt mưa rơi xuống không gian lắng yên\r\nSuy tư vấn vương ngồi mộng mơ\r\nĐơn phương nhớ đến một nàng thơ\r\nGió đông ùa về mang những ê chề (woh)\r\nNgỡ là trái tim khô cằn héo úa sẽ thôi buồn đau\r\nNhưng thật cay đắng khi biết là (ú oà)\r\nMình chỉ là một người đến sau (hey)\r\n\r\nBiết em đã có người ở gần bên\r\nNhưng anh sẽ vẫn đứng ngay đây và chờ em\r\nMưa giông bão tố chẳng quan tâm đến ngày đêm\r\nKẻ si tình này chọn ở phía sau thầm nhớ mong em bae bae\r\nVì say mê ánh mắt yêu luôn cả bờ môi\r\nMuốn nói với cả thế giới chỉ thương em mà thôi\r\nĐắm đuối uh cháy lên ngọn lửa tình yêu\r\nBùng lên mạnh mẽ và thiêu đốt baby that’s what I feel\r\nMy girl I’m waiting for you\r\n\r\n\r\nChờ em chờ em ừ thì chờ em\r\nChờ em chờ em chờ đến bao giờ\r\nBiển khô cạn trời không còn đầy sao\r\nThì anh vẫn nơi đây và chờ em\r\n\r\nBiết em đã có người ở gần bên\r\nNhưng anh sẽ vẫn đứng ngay đây và chờ em\r\nMưa giông bão tố chẳng quan tâm đến ngày đêm\r\nKẻ si tình này chọn ở phía sau thầm nhớ mong em bae bae\r\nVì say mê ánh mắt yêu luôn cả bờ môi\r\nMuốn nói với cả thế giới chỉ thương em mà thôi\r\nĐắm đuối uh cháy lên ngọn lửa tình yêu\r\nBùng lên mạnh mẽ và thiêu đốt baby that’s what I feel\r\nMy girl I’m waiting for you");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img2, 0, "Hơn em chỗ nào", "Thùy Chi", "5:09", "Đặng Tiến Hoàng", "D:\\Song\\2 Hon em cho nao.mp3", "Tự dưng nghĩ hay lỗi do mình vội đi\r\nGiá như chậm hơn chẳng lỡ buông lời\r\nVới tình yêu mình sẽ bớt buồn hơn\r\nTại đôi khi em chẳng thể hiểu được anh\r\nTrái tim này bên anh chăm sóc chữa lành\r\nĐiều gì đã khiến anh vứt bỏ đi hết\r\n\r\nPhải chăng rằng người ta tốt hơn em chỗ nào\r\nTại sao anh mang nỗi buồn giăng kín lối\r\nTình yêu vốn đẹp bởi từ cả hai sẽ mang lại ngọt ngào\r\nĐâu phải làm cho nước mắt rơi đâu\r\n\r\nPhải chăng rằng người ta ở bên anh lúc buồn\r\nCớ sao như vậy không tìm em lúc đấy\r\nVậy khi mỗi em một mình, người con gái luôn cần tìm\r\nAnh lại đang vui nơi ấy với ai\r\nNước mắt lại rơi\r\n\r\nEm không thể tin mọi thứ như vậy\r\nCó ai đau khổ thế này\r\nMột lần sau cuối\r\nCầu xin em đi mà\r\nCố gắng níu giữ em được không?\r\n\r\nPhải chăng rằng người ta tốt hơn em chỗ nào\r\nTại sao anh mang nỗi buồn giăng kín lối\r\nTình yêu vốn đẹp bởi từ cả hai sẽ mang lại ngọt ngào\r\nĐâu phải làm cho nước mắt rơi đâu\r\nPhải chăng rằng người ta ở bên anh lúc buồn\r\nCớ sao như vậy không tìm em lúc đấy\r\nVậy khi mỗi em một mình, người con gái luôn cần tìm\r\nAnh lại đang vui nơi ấy với ai\r\nNước mắt lại rơi");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img3, 0, "Túy âm", "Ngọc Mai", "6:04", "Xesi", "D:\\Song\\3 Tuy Am.mp3", "Rót đến tràn ly, anh chìm đắm trong men cay đắng nồng\r\nKhóc chát làn mi, uống cùng anh cho đêm nay say chất ngất !\r\nDẫu năm tháng ấy còn đâu những đam mê ta kiếm tìm?\r\nMàu mắt xanh ngời lạc giữa mây ngàn về chốn xa xôi\r\n\r\nHãy say cùng anh, hãy hát cùng anh, hãy khóc cùng anh\r\nThêm 1 lần...\r\nĐể anh được gần trái tim của em dù trong phút giây\r\nHình bóng người tan biến dần phía sau những nỗi sầu\r\n\r\nVới em chắc quá đủ cho một mối tình\r\nDẫu em không thể ở lại với anh\r\nMình chẳng cùng với nhau đi hết quãng đường, ôm ấp hi vọng một ngày ngát xanh\r\nTháng năm thăng trầm dòng đời ngả nghiêng\r\nMình tự rời bỏ nhau, say đến điên dại, say hết kiếp người, say cho cháy lòng");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img12, 0, "Anti-Hero", "Taylor Swift", "4:42", "Taylor Swift, Jack Antonoff", "D:\\Song\\15 Anti-Hero.mp3", "I have this thing where I get older, but just never wiser\r\nMidnights become my afternoons\r\nWhen my depression works the graveyard shift, all of the people\r\nI've ghosted stand there in the room\r\n\r\nI should not be left to my own devices\r\nThey come with prices and vices\r\nI end up in crisis\r\n(Tale as old as time)\r\nI wake up screaming from dreaming\r\nOne day, I'll watch as you're leaving\r\n'Cause you got tired of my scheming\r\n(For the last time)\r\n\r\nIt's me, hi\r\nI'm the problem, it's me\r\nAt teatime, everybody agrees\r\nI'll stare directly at the sun, but never in the mirror\r\nIt must be exhausting always rooting for the anti-hero");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img4, 0, "Nửa thập Kỷ", "Hà Trần", "6:58", "Hoàng Dũng", "\"D:\\Song\\4 Nua thap ky.mp3", "Thời gian phát ra điệu nhạc qua những lần đổi thay\r\nVài nhịp trễ không còn buồn, lời ca cũng đã đong đầy\r\nHuh... tôi như nghe thấy tất cả mọi điều\r\nNgoại trừ câu trả lời từ em\r\n\r\nTôi vẫn cứ cô đơn chờ đợi suốt nửa thập kỷ trôi\r\nTôi yêu em thiết tha chẳng thiết đến mình nữa rồi\r\nhuh... Sao em không nói hết một lần với tôi\r\nLiệu rằng tôi nên buông tay hay cứ cố níu lấy?\r\n\r\nNếu quá đau để buông lời tan vỡ\r\nHãy coi định mệnh là cái cớ cho câu trả lời\r\nĐể ánh mắt cuối trao cho nhau\r\nChẳng thấp thoáng chút thương hại nào\r\nĐể cho sự rời xa đúng nghĩa kết thúc những dang dở bấy lâu\r\nĐừng giết chết tôi bằng im lặng");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img5, 0, "Bước Qua Mùa Cô Đơn", "Uyên Linh", "5:56", "Vũ.", "D:\\Song\\5 Bước Qua Mùa Cô Đơn.mp3", "Cuộc đời cứ trôi\r\nTa nhìn lại ngày tháng còn bên nhau\r\nCùng những thăng trầm\r\nVà tại sao không vẫy tay chào nơi ta đứng bây giờ\r\nHai nơi hai người dưng\r\n\r\nĐợi em bước qua\r\nĐể khiến anh nhận ra là đôi mắt em còn đang buồn\r\nVà màu hoa cài áo vẫn còn như lời hứa đã từng\r\nGiờ đây còn như xưa\r\n\r\nDòng người vội vàng bước qua\r\nChợt như chiếc hôn thế thôi\r\nĐôi môi chia làm đôi\r\nNhư ta đang mong vậy thôi\r\nNgười nghẹn ngào bước đi\r\nChợt như chúng ta quay về\r\nGiấu trái tim mình và đừng thổn thức khi thấy nhau oh\r\nĐoàn tàu kia dừng lại (đoàn tàu kia)\r\nCòn hai ta trôi đi theo mây trời\r\nTừng cảm xúc trong tim anh đang cô đơn cùng với ngàn lời\r\nViết riêng cho bài ca tình đầu\r\nChỉ còn lại một thói quen từ lâu woh\r\nDòng người vội vàng bước qua\r\nChợt như chiếc hôn thế thôi\r\nĐôi môi chia làm đôi\r\nNhư ta đang mong vậy thôi oh oh");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img6, 0, "Dưới ánh đèn sân khấu", "Hà Trần, Ngọc Mai, Thùy Chi", "5:17", "Hứa Kim Tuyền", "D:\\Song\\6 Dưới Ánh Đèn Sân Khấu.mp3", "Khi ánh đèn sân khấu tắt đi\r\nTôi lại về tôi trong suy nghĩ\r\nMọi thứ đã qua tôi chờ mọi thứ đã qua\r\nThời gian nào đâu dễ xóa?\r\n\r\nTôi ước mình là một khúc ca\r\nThăng trầm tựa buồn vui câu hát\r\nNgồi xuống ngân nga, tôi lại ngồi xuống ngân nga\r\nĐể vui buồn mau chóng qua\r\n\r\nGiọt nước mắt rơi khi nào tôi cũng chẳng biết khi nào\r\nChỉ vì câu hát hay quá, yêu quá, thương quá,... nên khóc thôi\r\nTừng ký ức đan xen vào nỗi nhớ khiến cảm xúc tôi dâng trào\r\nVà tôi đón câu hát, tôi đón ánh sáng của chính tôi\r\nDưới ánh đèn sân khấu có nốt nhạc bay lên\r\nCó những kỷ niệm bay lên\r\nCó những nỗi niềm riêng\r\nGom thành một câu hát chạy thẳng vào tim\r\nCó những lúc cười hân hoan\r\nCó những lúc buồn miên man\r\nCó những lúc hoang tàn\r\nGom thành một câu hát chạy thẳng vào tim");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img13, 0, "Shut Down", "Black Pink", "3:36", "Teddy; 24", "D:\\Song\\17 Shut Down.mp3", "\"Blackpink in your area\r\nBlackpink in your area\r\n\r\n컴백이 아냐 떠난 적 없으니까\r\n고개들이 돌아 진정해 목 꺾일라\r\n분홍빛의 얼음 drip drip drip freeze ‘em on sight\r\nShut it down what what what what\r\n\r\n게임이 아냐 진 적이 없으니까\r\n짖어봐 네 목에 목줄은 내 거니까\r\n땅바닥에 닿은 pedal we go two zero five\r\nShut it down uh uh uh uh\r\n\r\n초록 비를 내려 머리 위로 Don’t trip, baby\r\n겸손하게 그냥 앉아있어 Just sit, baby\r\n\r\nPraying for my downfall, many have tried, baby\r\nCatch me when you hear my Lamborghini go vroom, vroom, vroom, vroom\r\n\r\nWhen we pull up you know it’s a shutdown\r\n간판 내리고 문 잠가 shut down\r\nWhip it whip it whip it whip it\r\nWhip it whip it whip it whip it\r\nIt’s black and it’s pink once the sun down\r\n\r\nWhen we pull up you know it’s a shutdown\r\n간판 내리고 문 잠가 shut down\r\nWhip it whip it whip it whip it\r\nWhip it whip it whip it whip it\r\nKeep watching me shut it down\r\n\r\nNah\r\nYou don’t wanna be on my bad side that’s right I’m slidin’ through\r\nBunch of wannabes that wanna be me, me three if I was you\r\nBeen around the world, pearls on ya girl, VVS's we invested uh\r\nNeed a lesson see the necklace, see these dresses\r\nWe don’t buy it we request it uh\r\n\r\nA rockstar, a popstar but rowdier\r\nSay bye to the paparazzi, get my good side, I'll smile for ya\r\nKnow it ain’t fair to ya, it’s scarin’ ya like what now\r\nBlackpink in your area, the area been shut down. It’s a shutdown\r\n\r\n네 다음 답안지야 똑바로 봐 don’t sleep baby\r\n뒤집어봐 이건 가격표야 ain’t cheap baby\r\n\r\nStay in your own lane ‘cause I’m ‘bout to swerve\r\nCatch me when you hear my Lamborghini go vroom, vroom, vroom, vroom\r\n\r\nWhen we pull up you know it’s a shutdown\r\n간판 내리고 문 잠가 shut down\r\n\r\nWhip it whip it whip it whip it\r\nWhip it whip it whip it whip it\r\n\r\nIt’s black and it’s pink once the sun down\r\n\r\nWhen we pull up you know it’s a shutdown\r\n간판 내리고 문 잠가 shut down\r\n\r\nWhip it whip it whip it whip it\r\nWhip it whip it whip it whip it\r\n\r\nKeep watching me shut it down\r\n\r\nShut it down Blackpink in your area\r\nShut it down woah woah woah woah\r\nShut it down Blackpink in your area\r\nKeep talking we shut you down\"");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img7, 0, "Vũ điệu gió", "Ngọc Mai", "4:12", "Vũ Minh Tâm", "D:\\Song\\7 Vu dieu gio.mp3", "Cùng em bay qua những miền đất có chim muông hòa ca\r\nCùng em bay qua những ngọn núi cao vút trời\r\nCùng mây gió dạo chơi nhìn ngắm hoàng hôn\r\nCùng em xoay trong vũ điệu gió\r\nĐắm say trong chiều vàng\r\n\r\nCùng em bơi trên những ngọn sóng phía bên kia đại dương\r\nCùng em bơi qua những ghềnh thác khe núi sâu\r\nLời em hát tựa gió vọng mãi rừng xanh\r\nCùng em đi qua những ngay tháng\r\nĐắm say bao nồng nàn\r\n\r\nNgày anh về mang bình yên\r\nNgày anh về bao trìu mến\r\nNgày anh về xóa tan lạnh giá\r\nGió reo chim hòa ca\r\nCùng em dạo trên đồng xanh\r\nCùng em chạy theo làn gió\r\nNhững thanh âm êm đềm hát thầm\r\nRằng ta cần nhau mãi\r\n\r\nNgày anh về mang bình yên\r\nNgày anh về bao trìu mến\r\nNgày anh về xóa tan lạnh giá\r\nGió reo chim hòa ca\r\nCùng em dạo trên đồng xanh\r\nCùng em chạy theo làn gió\r\nNhững thanh âm êm đềm hát thầm\r\nRằng ta cần nhau mãi\r\n\r\nCùng em say sưa hát bài hát lứa đôi ta kề vai\r\nCùng em say sưa đón chào muôn tia nắng mai\r\nLời ta hát tựa gió vọng mãi ngàn sau\r\nVà ta xoay trong vũ điệu gió\r\n\r\nCùng em say sưa hát bài hát lứa đôi ta kề vai\r\nCùng em say sưa đón chào muôn tia nắng mai\r\nLời ta hát tựa gió vọng mãi ngàn sau\r\nVà ta xoay trong vũ điệu gió\r\nĐắm say bao tuyệt vời");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img8, 0, "Xem như em chẳng may", "Lương Bích Hữu", "4:42", "Trung Ngon", "D:\\Song\\8 Xem nhu em chang may.mp3", "\"Người hôm qua em thấy là ai đấy\r\nSao anh lại chết lặng như vậy\r\nMột giờ đêm sao anh còn chưa nhắn tin về\r\nEm cứ mãi ngẩn ngơ chờ anh\r\n\r\nTại sao yêu đến thế lại gian dối\r\nCon tim em vỡ tan mất rồi\r\nTưởng chừng ta hạnh phúc cùng nhau đến muôn đời\r\nChưa buông tay anh thay áo mới\r\n\r\nNgọt ngào đến mấy cũng tan thành mây\r\nDại khờ thuở ấy khi đan bàn tay\r\nYêu thương trao hết chỉ giữ lại đây thân gầy\r\nXem như em chẳng may\r\n\r\nNỗi buồn em giấu sau lớp màn mưa\r\nGượng cười khi biết em là người giữa hai người\r\nCòn lại gì cho nhau\r\nNgoài những lời ngôn tình quá dư thừa\r\n\r\nEm không muốn nghe\r\nHeh\r\nEm không muốn nghe\r\nHeh\r\n\"");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img9, 0, "Việt Nam trong tôi là", "Thùy Chi", "5:22", "Yến Lê", "D:\\Song\\8 Xem nhu em chang may.mp3", "\"Người hôm qua em thấy là ai đấy\r\nSao anh lại chết lặng như vậy\r\nMột giờ đêm sao anh còn chưa nhắn tin về\r\nEm cứ mãi ngẩn ngơ chờ anh\r\n\r\nTại sao yêu đến thế lại gian dối\r\nCon tim em vỡ tan mất rồi\r\nTưởng chừng ta hạnh phúc cùng nhau đến muôn đời\r\nChưa buông tay anh thay áo mới\r\n\r\nNgọt ngào đến mấy cũng tan thành mây\r\nDại khờ thuở ấy khi đan bàn tay\r\nYêu thương trao hết chỉ giữ lại đây thân gầy\r\nXem như em chẳng may\r\n\r\nNỗi buồn em giấu sau lớp màn mưa\r\nGượng cười khi biết em là người giữa hai người\r\nCòn lại gì cho nhau\r\nNgoài những lời ngôn tình quá dư thừa\r\n\r\nEm không muốn nghe\r\nHeh\r\nEm không muốn nghe\r\nHeh\r\n\"");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img10, 0, "Cám dỗ", "Myra Trần", "3:27", "Hứa Kim Tuyền", "D:\\Song\\8 Xem nhu em chang may.mp3", "\"Người hôm qua em thấy là ai đấy\r\nSao anh lại chết lặng như vậy\r\nMột giờ đêm sao anh còn chưa nhắn tin về\r\nEm cứ mãi ngẩn ngơ chờ anh\r\n\r\nTại sao yêu đến thế lại gian dối\r\nCon tim em vỡ tan mất rồi\r\nTưởng chừng ta hạnh phúc cùng nhau đến muôn đời\r\nChưa buông tay anh thay áo mới\r\n\r\nNgọt ngào đến mấy cũng tan thành mây\r\nDại khờ thuở ấy khi đan bàn tay\r\nYêu thương trao hết chỉ giữ lại đây thân gầy\r\nXem như em chẳng may\r\n\r\nNỗi buồn em giấu sau lớp màn mưa\r\nGượng cười khi biết em là người giữa hai người\r\nCòn lại gì cho nhau\r\nNgoài những lời ngôn tình quá dư thừa\r\n\r\nEm không muốn nghe\r\nHeh\r\nEm không muốn nghe\r\nHeh\r\n\"");
            dt_Viral.Rows.Add("VIR", Properties.Resources.img11, 0, "Dạ vũ", "Hà Nhi", "4:22", "Tăng Duy Tân", "D:\\Song\\8 Xem nhu em chang may.mp3", "\"Người hôm qua em thấy là ai đấy\r\nSao anh lại chết lặng như vậy\r\nMột giờ đêm sao anh còn chưa nhắn tin về\r\nEm cứ mãi ngẩn ngơ chờ anh\r\n\r\nTại sao yêu đến thế lại gian dối\r\nCon tim em vỡ tan mất rồi\r\nTưởng chừng ta hạnh phúc cùng nhau đến muôn đời\r\nChưa buông tay anh thay áo mới\r\n\r\nNgọt ngào đến mấy cũng tan thành mây\r\nDại khờ thuở ấy khi đan bàn tay\r\nYêu thương trao hết chỉ giữ lại đây thân gầy\r\nXem như em chẳng may\r\n\r\nNỗi buồn em giấu sau lớp màn mưa\r\nGượng cười khi biết em là người giữa hai người\r\nCòn lại gì cho nhau\r\nNgoài những lời ngôn tình quá dư thừa\r\n\r\nEm không muốn nghe\r\nHeh\r\nEm không muốn nghe\r\nHeh\r\n\"");


            dt_All.Merge(dt_Viral);
            dt_All.Merge(dt_Vpop);


        }

        private void pan_navbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void b_home_viral_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            a_type.Text = "Viral";
            a_pan_visual_banner.Image = Properties.Resources.banner1;

            a_pan_playlist.Visible = true;

            flowLayoutPanel1.Controls.Clear();

            uc_songlist[] songlists = new uc_songlist[35];

            for (int i = 0; i < dt_All.Rows.Count; i++)
            {
                songlists[i] = new uc_songlist();
                songlists[i].coverpic.Image = (Image)dt_All.Rows[i]["hinhanh"];
                //songlists[i].coverpic.BackgroundImage = (Image)Properties.Resources.img1;
                songlists[i].songname.Text = dt_All.Rows[i]["tenbaihat"].ToString();
                songlists[i].artist.Text = dt_All.Rows[i]["tencasi"].ToString();

                songlists[i].compose.Text = dt_All.Rows[i]["tacgia"].ToString();
                songlists[i].time.Text = dt_All.Rows[i]["thoiluong"].ToString();
                songlists[i].lyric.Text = dt_All.Rows[i]["loibaihat"].ToString();
                songlists[i].link.Text = dt_All.Rows[i]["baihat"].ToString();
                //songlists[i].like.Text = dt_All.Rows[i]["liked"].ToString();


                flowLayoutPanel1.Controls.Add(songlists[i]);

                songlists[i].Click += new System.EventHandler(this.Usercontrol_Click);
            }
            a_pan_playlist.Visible = true;
        }



        private void pictureBox4_Click(object sender, EventArgs e)
        {

            if (a_type.Text == "Viral" || a_type.Text == "Liked")
            {
                //Liked
                var rows = dt_Viral.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Viral.Rows.IndexOf(line);

                    if (Convert.ToInt32(dt_Viral.Rows[index]["liked"]) == 0)
                    {
                        dt_Viral.Rows[index]["liked"] = 1;
                        c_like.Image = Properties.Resources.liked;
                        dt_Liked.ImportRow(line);
                    }
                    else if (Convert.ToInt32(dt_Viral.Rows[index]["liked"]) == 1)
                    {
                        dt_Viral.Rows[index]["liked"] = 0;
                        c_like.Image = Properties.Resources.dislike;

                        var toDelete = dt_Liked.AsEnumerable().
                            Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                        foreach (DataRow rowToDelete in toDelete)
                            rowToDelete.Delete();
                        dt_Liked.AcceptChanges();


                    }
                }
            }

            if (a_type.Text == "VPop" || a_type.Text == "Liked")
            {

                var rows = dt_Vpop.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Vpop.Rows.IndexOf(line);

                    if (Convert.ToInt32(dt_Vpop.Rows[index]["liked"]) == 0)
                    {
                        dt_Vpop.Rows[index]["liked"] = 1;
                        c_like.Image = Properties.Resources.liked;
                        dt_Liked.ImportRow(line);
                    }
                    else if (Convert.ToInt32(dt_Vpop.Rows[index]["liked"]) == 1)
                    {
                        dt_Vpop.Rows[index]["liked"] = 0;
                        c_like.Image = Properties.Resources.dislike;

                        var toDelete = dt_Liked.AsEnumerable().
                            Where(r => r.Field<string>("tenbaihat") == c_songname.Text);


                        //var likedrow = dt_Liked.AsEnumerable()
                        //    .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                        //foreach (var row in likedrow)
                        //{
                        //    int i = dt_Liked.Rows.IndexOf(line);
                        //    dt_Liked.Rows.Remove(row);
                        //    dt_Liked.AcceptChanges();
                        //}

                        foreach (DataRow rowToDelete in toDelete)
                            rowToDelete.Delete();
                        dt_Liked.AcceptChanges();


                    }
                }
            }

            //else if (a_type.Text == "VPop")
            //{

            //    var rows = dt_Vpop.AsEnumerable()
            //       .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

            //    foreach (var line in rows)
            //    {
            //        int index = dt_Vpop.Rows.IndexOf(line);

            //        if (Convert.ToInt32(dt_Vpop.Rows[index]["liked"]) == 0)
            //        {
            //            dt_Vpop.Rows[index]["liked"] = 1;
            //            c_like.Image = Properties.Resources.liked;
            //            dt_Liked.ImportRow(line);
            //        }
            //        else if (Convert.ToInt32(dt_Vpop.Rows[index]["liked"]) == 1)
            //        {
            //            dt_Vpop.Rows[index]["liked"] = 0;
            //            c_like.Image = Properties.Resources.dislike;

            //            var toDelete = dt_Liked.AsEnumerable().
            //                Where(r => r.Field<string>("tenbaihat") == c_songname.Text);


            //            //var likedrow = dt_Liked.AsEnumerable()
            //            //    .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

            //            //foreach (var row in likedrow)
            //            //{
            //            //    int i = dt_Liked.Rows.IndexOf(line);
            //            //    dt_Liked.Rows.Remove(row);
            //            //    dt_Liked.AcceptChanges();
            //            //}

            //            foreach (DataRow rowToDelete in toDelete)
            //                rowToDelete.Delete();
            //        }
            //    }
            //}

            dt_Liked.AcceptChanges();


        }

        private void label3_Click(object sender, EventArgs e)
        {
            c_pan_detail.Visible = false;
            if (a_type.Text == "Liked")
            {
                b_pan_liked_Click(sender, e);
            }
            //b_pan_liked_Click(sender, e);


        }

        private void c_play_Click(object sender, EventArgs e)
        {
            picb_songcover.Image = c_picb_cover.Image;
            lab_songname.Text = c_songname.Text;
            lab_artist.Text = c_artist.Text;
            player.URL = c_link.Text;

            player.Ctlcontrols.play();
        }


        private void pan_nav_btt_home_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel && c != pan_home && c != pan_navbar)
                {
                    c.Visible = false;
                }

            }
        }

        private void b_pan_liked_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            a_type.Text = "Liked";
            a_pan_visual_banner.Image = Properties.Resources.banner3;

            a_pan_playlist.Visible = true;

            flowLayoutPanel1.Controls.Clear();

            uc_songlist[] songlists = new uc_songlist[20];

            for (int i = 0; i < dt_Liked.Rows.Count; i++)
            {
                songlists[i] = new uc_songlist();
                songlists[i].coverpic.Image = (Image)dt_Liked.Rows[i]["hinhanh"];
                //songlists[i].coverpic.BackgroundImage = (Image)Properties.Resources.img1;
                songlists[i].songname.Text = dt_Liked.Rows[i]["tenbaihat"].ToString();
                songlists[i].artist.Text = dt_Liked.Rows[i]["tencasi"].ToString();

                songlists[i].compose.Text = dt_Liked.Rows[i]["tacgia"].ToString();
                songlists[i].time.Text = dt_Liked.Rows[i]["thoiluong"].ToString();
                songlists[i].lyric.Text = dt_Liked.Rows[i]["loibaihat"].ToString();
                songlists[i].link.Text = dt_Liked.Rows[i]["baihat"].ToString();
                //songlists[i].like.Text = dt_Viral.Rows[i]["liked"].ToString();


                flowLayoutPanel1.Controls.Add(songlists[i]);

                songlists[i].Click += new System.EventHandler(this.Usercontrol_Click);
            }
        }

        private void b_home_vpop_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            a_type.Text = "VPop";
            a_pan_visual_banner.Image = Properties.Resources.banner2;

            a_pan_playlist.Visible = true;

            flowLayoutPanel1.Controls.Clear();

            uc_songlist[] songlists = new uc_songlist[20];

            for (int i = 0; i < dt_Vpop.Rows.Count; i++)
            {
                songlists[i] = new uc_songlist();
                songlists[i].coverpic.Image = (Image)dt_Vpop.Rows[i]["hinhanh"];
                //songlists[i].coverpic.BackgroundImage = (Image)Properties.Resources.img1;
                songlists[i].songname.Text = dt_Vpop.Rows[i]["tenbaihat"].ToString();
                songlists[i].artist.Text = dt_Vpop.Rows[i]["tencasi"].ToString();

                songlists[i].compose.Text = dt_Vpop.Rows[i]["tacgia"].ToString();
                songlists[i].time.Text = dt_Vpop.Rows[i]["thoiluong"].ToString();
                songlists[i].lyric.Text = dt_Vpop.Rows[i]["loibaihat"].ToString();
                songlists[i].link.Text = dt_Vpop.Rows[i]["baihat"].ToString();
                //songlists[i].like.Text = dt_Vpop.Rows[i]["liked"].ToString();


                flowLayoutPanel1.Controls.Add(songlists[i]);

                songlists[i].Click += new System.EventHandler(this.Usercontrol_Click);
            }
            a_pan_playlist.Visible = true;
        }


        private void c_add_Click(object sender, EventArgs e)
        {

            if (a_type.Text == "Viral")
            {

                var rows = dt_Viral.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Viral.Rows.IndexOf(line);
                    dt_MyList.ImportRow(line);
                }
            }

            if (a_type.Text == "VPop")
            {

                var rows = dt_Vpop.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Vpop.Rows.IndexOf(line);
                    dt_MyList.ImportRow(line);
                }
            }
            c_add.Visible = false;
        }

        private void b_pan_myplaylist_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            pictureBox3.Visible = false;
            c_pan_detail.Visible = false;
            a_type.Text = "MyList";
            a_pan_visual_banner.Image = Properties.Resources.banner4;

            a_pan_playlist.Visible = true;

            flowLayoutPanel1.Controls.Clear();

            uc_songlist[] songlists = new uc_songlist[20];

            for (int i = 0; i < dt_MyList.Rows.Count; i++)
            {
                songlists[i] = new uc_songlist();
                songlists[i].coverpic.Image = (Image)dt_MyList.Rows[i]["hinhanh"];
                //songlists[i].coverpic.BackgroundImage = (Image)Properties.Resources.img1;
                songlists[i].songname.Text = dt_MyList.Rows[i]["tenbaihat"].ToString();
                songlists[i].artist.Text = dt_MyList.Rows[i]["tencasi"].ToString();

                songlists[i].compose.Text = dt_MyList.Rows[i]["tacgia"].ToString();
                songlists[i].time.Text = dt_MyList.Rows[i]["thoiluong"].ToString();
                songlists[i].lyric.Text = dt_MyList.Rows[i]["loibaihat"].ToString();
                songlists[i].link.Text = dt_MyList.Rows[i]["baihat"].ToString();
                //songlists[i].like.Text = dt_Viral.Rows[i]["MyList"].ToString();


                flowLayoutPanel1.Controls.Add(songlists[i]);

                songlists[i].Click += new System.EventHandler(this.Usercontrol_Click);
            }
        }

        private void c_download_Click(object sender, EventArgs e)
        {
            string fileName = c_songname.Text + ".mp3";
            string sourceFile = c_link.Text.ToString();
            string targetPath = @"C:\Users\ttanl\OneDrive - Trường ĐH CNTT - University of Information Technology\Máy tính\Download Song";

            string destFile = System.IO.Path.Combine(targetPath, fileName);


            System.IO.File.Copy(sourceFile, destFile, true);
            c_download.BackColor = Color.ForestGreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            uc_cmt uc_cmt = new uc_cmt();
            uc_cmt usercmt = uc_cmt;

            usercmt.label2.Text = textBox1.Text;

            textBox1.Text = "";

            c_flowpan_cmt.Controls.Add(usercmt);


        }
        void Usercontrol_Click(object sender, EventArgs e)
        {
            c_download.BackColor = c_songname.BackColor;
            c_flowpan_cmt.Controls.Clear();

            uc_songlist obj = (uc_songlist)sender;

            c_picb_cover.Image = (Image)obj.coverpic.Image;
            c_songname.Text = obj.songname.Text;
            c_artist.Text = obj.artist.Text;
            c_link.Text = obj.link.Text;
            c_add.Visible = true;

            //player.URL = "D:\\Download\\1 Waiting For You.mp3";

            //player.Ctlcontrols.play();

            if (a_type.Text == "Viral")
            {
                var rows = dt_Viral.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Viral.Rows.IndexOf(line);
                    c_lyrics.Text = dt_Viral.Rows[index]["loibaihat"].ToString();
                    c_like.Visible = true;
                    c_add.Visible = true;
                    if (Convert.ToInt32(dt_Viral.Rows[index]["liked"]) == 0)
                        c_like.Image = Properties.Resources.dislike;
                    else
                    {
                        if (Convert.ToInt32(dt_Viral.Rows[index]["liked"]) == 1)
                            c_like.Image = Properties.Resources.liked;
                    }
                }
            }

            else if (a_type.Text == "VPop")
            {
                var rows = dt_Vpop.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Vpop.Rows.IndexOf(line);
                    c_lyrics.Text = dt_Vpop.Rows[index]["loibaihat"].ToString();
                    c_like.Visible = true;
                    c_add.Visible = true;
                    if (Convert.ToInt32(dt_Vpop.Rows[index]["liked"]) == 0)
                        c_like.Image = Properties.Resources.dislike;
                    else
                    {
                        if (Convert.ToInt32(dt_Vpop.Rows[index]["liked"]) == 1)
                            c_like.Image = Properties.Resources.liked;
                    }
                }
            }


            else if (a_type.Text == "Liked")
            {
                var rows = dt_Liked.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_Liked.Rows.IndexOf(line);
                    c_lyrics.Text = dt_Liked.Rows[index]["loibaihat"].ToString();
                    c_add.Visible = false;
                    if (Convert.ToInt32(dt_Liked.Rows[index]["liked"]) == 0)
                        c_like.Image = Properties.Resources.dislike;
                    else
                    {
                        if (Convert.ToInt32(dt_Liked.Rows[index]["liked"]) == 1)
                            c_like.Image = Properties.Resources.liked;
                    }
                }
            }

            else if (a_type.Text == "MyList")
            {
                var rows = dt_MyList.AsEnumerable()
                   .Where(r => r.Field<string>("tenbaihat") == c_songname.Text);

                foreach (var line in rows)
                {
                    int index = dt_MyList.Rows.IndexOf(line);
                    c_lyrics.Text = dt_MyList.Rows[index]["loibaihat"].ToString();
                    c_like.Visible = false;
                    c_add.Visible = false;
                }
                c_add.Visible = false;
            }





            //c_lyrics.Text = "Chiều đang dần buông hạt mưa rơi xuống không gian lắng yên\r\nSuy tư vấn vương ngồi mộng mơ\r\nĐơn phương nhớ đến một nàng thơ\r\nGió đông ùa về mang những ê chề (woh)\r\nNgỡ là trái tim khô cằn héo úa sẽ thôi buồn đau\r\nNhưng thật cay đắng khi biết là (ú oà)\r\nMình chỉ là một người đến sau (hey)\r\n\r\nBiết em đã có người ở gần bên\r\nNhưng anh sẽ vẫn đứng ngay đây và chờ em\r\nMưa giông bão tố chẳng quan tâm đến ngày đêm\r\nKẻ si tình này chọn ở phía sau thầm nhớ mong em bae bae\r\nVì say mê ánh mắt yêu luôn cả bờ môi\r\nMuốn nói với cả thế giới chỉ thương em mà thôi\r\nĐắm đuối uh cháy lên ngọn lửa tình yêu\r\nBùng lên mạnh mẽ và thiêu đốt baby that’s what I feel\r\nMy girl I’m waiting for you\r\n\r\n\r\nChờ em chờ em ừ thì chờ em\r\nChờ em chờ em chờ đến bao giờ\r\nBiển khô cạn trời không còn đầy sao\r\nThì anh vẫn nơi đây và chờ em\r\n\r\nBiết em đã có người ở gần bên\r\nNhưng anh sẽ vẫn đứng ngay đây và chờ em\r\nMưa giông bão tố chẳng quan tâm đến ngày đêm\r\nKẻ si tình này chọn ở phía sau thầm nhớ mong em bae bae\r\nVì say mê ánh mắt yêu luôn cả bờ môi\r\nMuốn nói với cả thế giới chỉ thương em mà thôi\r\nĐắm đuối uh cháy lên ngọn lửa tình yêu\r\nBùng lên mạnh mẽ và thiêu đốt baby that’s what I feel\r\nMy girl I’m waiting for you";

            //switch (c_songname.Text)
            //{
            //    case "Watting for you":
            //        c_lyrics.Text = "Chiều đang dần buông hạt mưa rơi xuống không gian lắng yên\r\nSuy tư vấn vương ngồi mộng mơ\r\nĐơn phương nhớ đến một nàng thơ\r\nGió đông ùa về mang những ê chề (woh)\r\nNgỡ là trái tim khô cằn héo úa sẽ thôi buồn đau\r\nNhưng thật cay đắng khi biết là (ú oà)\r\nMình chỉ là một người đến sau (hey)\r\n\r\nBiết em đã có người ở gần bên\r\nNhưng anh sẽ vẫn đứng ngay đây và chờ em\r\nMưa giông bão tố chẳng quan tâm đến ngày đêm\r\nKẻ si tình này chọn ở phía sau thầm nhớ mong em bae bae\r\nVì say mê ánh mắt yêu luôn cả bờ môi\r\nMuốn nói với cả thế giới chỉ thương em mà thôi\r\nĐắm đuối uh cháy lên ngọn lửa tình yêu\r\nBùng lên mạnh mẽ và thiêu đốt baby that’s what I feel\r\nMy girl I’m waiting for you\r\n\r\n\r\nChờ em chờ em ừ thì chờ em\r\nChờ em chờ em chờ đến bao giờ\r\nBiển khô cạn trời không còn đầy sao\r\nThì anh vẫn nơi đây và chờ em\r\n\r\nBiết em đã có người ở gần bên\r\nNhưng anh sẽ vẫn đứng ngay đây và chờ em\r\nMưa giông bão tố chẳng quan tâm đến ngày đêm\r\nKẻ si tình này chọn ở phía sau thầm nhớ mong em bae bae\r\nVì say mê ánh mắt yêu luôn cả bờ môi\r\nMuốn nói với cả thế giới chỉ thương em mà thôi\r\nĐắm đuối uh cháy lên ngọn lửa tình yêu\r\nBùng lên mạnh mẽ và thiêu đốt baby that’s what I feel\r\nMy girl I’m waiting for you";
            //        break;
            //    case "Hơn em chỗ nào":
            //        c_lyrics.Text = "Tự dưng nghĩ hay lỗi do mình vội đi\r\nGiá như chậm hơn chẳng lỡ buông lời\r\nVới tình yêu mình sẽ bớt buồn hơn\r\nTại đôi khi em chẳng thể hiểu được anh\r\nTrái tim này bên anh chăm sóc chữa lành\r\nĐiều gì đã khiến anh vứt bỏ đi hết\r\n\r\nPhải chăng rằng người ta tốt hơn em chỗ nào\r\nTại sao anh mang nỗi buồn giăng kín lối\r\nTình yêu vốn đẹp bởi từ cả hai sẽ mang lại ngọt ngào\r\nĐâu phải làm cho nước mắt rơi đâu\r\n\r\nPhải chăng rằng người ta ở bên anh lúc buồn\r\nCớ sao như vậy không tìm em lúc đấy\r\nVậy khi mỗi em một mình, người con gái luôn cần tìm\r\nAnh lại đang vui nơi ấy với ai\r\nNước mắt lại rơi\r\n\r\nEm không thể tin mọi thứ như vậy\r\nCó ai đau khổ thế này\r\nMột lần sau cuối\r\nCầu xin em đi mà\r\nCố gắng níu giữ em được không?\r\n\r\nPhải chăng rằng người ta tốt hơn em chỗ nào\r\nTại sao anh mang nỗi buồn giăng kín lối\r\nTình yêu vốn đẹp bởi từ cả hai sẽ mang lại ngọt ngào\r\nĐâu phải làm cho nước mắt rơi đâu\r\nPhải chăng rằng người ta ở bên anh lúc buồn\r\nCớ sao như vậy không tìm em lúc đấy\r\nVậy khi mỗi em một mình, người con gái luôn cần tìm\r\nAnh lại đang vui nơi ấy với ai\r\nNước mắt lại rơi";
            //        break;
            //    case "Túy âm":
            //        c_lyrics.Text = dt_Viral.Rows[3]["loibaihat"].ToString();
            //        break;
            //}


            c_pan_detail.Visible = true;

        }

        private void c_picb_cover_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(c_songname.Text);

        }

        private void label6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void pan_nav_his_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void lab_songname_TextChanged(object sender, EventArgs e)
        {
            if (lab_his.Text == "None") lab_his.Text = "";
            lab_his.Text += "‣ " + (DateTime.Now.ToString() + "    ") + lab_songname.Text.ToString() + "\r\n\r\n";
        }

        private void nav_btn_search_Click(object sender, EventArgs e)
        {
            a_pan_playlist.Visible = true;
            c_pan_detail.Visible = false;
            comboBox1.Visible = true;
            pictureBox3.Visible = true;
            a_pan_visual_banner.Image = Properties.Resources.nonebg;
            flowLayoutPanel1.Controls.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            uc_songlist[] songlists = new uc_songlist[1000];

            var i = 0;
            StringComparison stringComparison;
            EnumerableRowCollection<DataRow> matches;

            //var matches = dt_MyList.AsEnumerable().Where(r => r.Field<string>("tenbaihat").Contains(comboBox1.Text));
            if (comboBox1.Text.Length < 2)
            {
                stringComparison = StringComparison.Ordinal; //bỏ qua viet HOA
                matches = dt_All.AsEnumerable().Where(row => row.Field<string>("tenbaihat").IndexOf(comboBox1.Text.ToString().ToUpper(), stringComparison) != -1);

            }

            else
            {
                stringComparison = StringComparison.OrdinalIgnoreCase; //bỏ qua viet HOA
                matches = dt_All.AsEnumerable().Where(row => row.Field<string>("tenbaihat").IndexOf(comboBox1.Text.ToString(), stringComparison) != -1);
            }



            foreach (var match in matches)      //tạo list cac bai hat da tim thay
            {
                int index = dt_All.Rows.IndexOf(match);

                songlists[i] = new uc_songlist();
                songlists[i].coverpic.Image = (Image)dt_All.Rows[index]["hinhanh"];
                //songlists[i].coverpic.BackgroundImage = (Image)Properties.Resources.img1;
                songlists[i].songname.Text = dt_All.Rows[index]["tenbaihat"].ToString();
                songlists[i].artist.Text = dt_All.Rows[index]["tencasi"].ToString();

                songlists[i].compose.Text = dt_All.Rows[index]["tacgia"].ToString();
                songlists[i].time.Text = dt_All.Rows[index]["thoiluong"].ToString();
                songlists[i].lyric.Text = dt_All.Rows[index]["loibaihat"].ToString();
                songlists[i].link.Text = dt_All.Rows[index]["baihat"].ToString();
                //songlists[i].like.Text = dt_Viral.Rows[i]["All"].ToString

                flowLayoutPanel1.Controls.Add(songlists[i]);

                songlists[i].Click += new System.EventHandler(this.Usercontrol_Click);
                i++;
            }


            if (comboBox1.Text.Length > 1)
            {
                stringComparison = StringComparison.OrdinalIgnoreCase; //bỏ qua viet HOA
                matches = dt_All.AsEnumerable().Where(row => row.Field<string>("tencasi").IndexOf(comboBox1.Text.ToString(), stringComparison) != -1);

                foreach (var match in matches)      //tạo list cac bai hat da tim thay
                {
                    int index = dt_All.Rows.IndexOf(match);

                    songlists[i] = new uc_songlist();
                    songlists[i].coverpic.Image = (Image)dt_All.Rows[index]["hinhanh"];
                    //songlists[i].coverpic.BackgroundImage = (Image)Properties.Resources.img1;
                    songlists[i].songname.Text = dt_All.Rows[index]["tenbaihat"].ToString();
                    songlists[i].artist.Text = dt_All.Rows[index]["tencasi"].ToString();

                    songlists[i].compose.Text = dt_All.Rows[index]["tacgia"].ToString();
                    songlists[i].time.Text = dt_All.Rows[index]["thoiluong"].ToString();
                    songlists[i].lyric.Text = dt_All.Rows[index]["loibaihat"].ToString();
                    songlists[i].link.Text = dt_All.Rows[index]["baihat"].ToString();
                    //songlists[i].like.Text = dt_Viral.Rows[i]["All"].ToString

                    flowLayoutPanel1.Controls.Add(songlists[i]);

                    songlists[i].Click += new System.EventHandler(this.Usercontrol_Click);
                    i++;
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            pictureBox3_Click(sender, e);
        }
    }
}
