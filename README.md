# krkrFgiEditor
吉里吉里立绘合成工具

## 注意
此Fork纯属图一乐，~~追求生产力/稳定性~~任何情况下仍建议使用[CjangCjengh/krkrFgiEditor](https://github.com/CjangCjengh/krkrFgiEditor)的原版本
![](Screenshot.png)

## 一、合成单张立绘

1、打开坐标文件，格式为txt或json，名字一般为角色名，如：芳乃a.txt、寧々a_0.txt、face白狗a.txt、あやせa.pbd.json等。

2、程序会自动检测坐标文件的编码格式，原理为计算用各种编码打开时非日非英的字符数量，然后选用超范围的字符数量最少的编码。

3、选择图层，坐标文件中未指定图层组的图层统一放在名为“(none)”的图层组中。

4、在图层框中越上面的图层合成时铺在越底下，默认在添加图层时会对已选择的图层自动排序，原理为计算每个图层所有像素Alpha值的总和，和越大的图层铺在越底下。

5、保存结果。

## 二、批量合成

1、点击“新建”在左框中创建新的图层组，选中某一图层组后在右框中添加相应的图层。

2、选中图层或图层组后按backspace可以移除该项。

3、合成时越上面的图层组铺在越底下，图层组中图层的顺序不会影响合成结果。

4、选中右框中的任一图层后按“新建”可以添加名为“(none)”的空白图层。一个图层组最多只能有一个空白图层，且必须包含空白图层以外的图层。

5、合成规则。

假如有如下三个图层组：

组1：1、2

组2：3、(none)

组3：4、5

那么合成的结果为：1+3+4、1+3+5、1+4、1+5、2+3+4、2+3+5、2+4、2+5。

6、选择保存路径。

7、点击“开始合成”。
