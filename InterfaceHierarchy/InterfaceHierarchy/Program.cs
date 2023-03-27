using InterfaceHierarchy;


var myBitmap = new BitmapImage();

myBitmap.Draw();
int top, left, bottom, right;
Console.WriteLine("Enter top value");
top = int.Parse(Console.ReadLine());
Console.WriteLine("Enter left value");
left = int.Parse(Console.ReadLine());
Console.WriteLine("Enter bottom value");
bottom = int.Parse(Console.ReadLine());
Console.WriteLine("Enter right value");
right = int.Parse(Console.ReadLine());
myBitmap.DrawInBoundingBox(left, top, right, bottom);
myBitmap.DrawUpsideDown();

IAdvancedDraw iAdvDraw = myBitmap as IAdvancedDraw;
if(iAdvDraw != null)
{
    iAdvDraw.DrawUpsideDown();
    Console.ReadLine();
}
