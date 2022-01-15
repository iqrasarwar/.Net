
//LITERAL METHOD
let vehicle =
{
   Name: 'v1',
   Model : 'm1',
   Type : 'cc',
   PrintByLiteralSyntax:function()
   {
      console.log(this);
   },
   //ES6 WAY OF ADDING METHOD
   Print()
   {
      console.log("literal method");
   }
}
vehicle.PrintByLiteralSyntax();

//factory pattren

function createVehicle(n,m)
{
   let p = new Object();
   p.name = n;
   p.model = m;
   p.PrintByFactoryPattren = function ()
   {
      console.log(this);
   };
   return p;
}
let v = createVehicle("v2","cc");
v.PrintByFactoryPattren();

//CONSTRUCTOR PATTREN

function vehicleC(n,m)
{
   this.name = n;
   this.model = m;
   this.PrintByConstructorMethod = function ()
   {
      console.log(this);
   }
}
let vx = new vehicleC("v3","cc")
vx.PrintByConstructorMethod();
//construcotr with prototype
function vehicle3(n,m)
{
   this.name = n;
   this.model = m;
   vehicle3.prototype.PrintByProtoType= function()
   {
      console.log(this);
   }
}
let vvx = new vehicle3('vvx','cc');
vvx.PrintByProtoType();

function v4(n,m,c)
{
   this.name = n;
   this.model = m;
   v4.prototype.color = c;
   v4.prototype.PrintByProtoType= function()
   {
      console.log(this);
   }
   v4.prototype.PrintColor= function()
   {
      console.log(this.color);
   }
}
let x = new v4('vvx','cc','b');
x.PrintByProtoType();
let x1 = new v4('vvx2','cc','b');
x1.PrintByProtoType();
v4.prototype.color = "black";
x.PrintColor();
x1.PrintColor();
