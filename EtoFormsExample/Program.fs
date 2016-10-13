open Eto
open Eto.Forms
open Eto.Drawing

let app = new Application()

let form = new Form(Title="Curves", Size=Size(640, 480))
let cpt = [|PointF(20.f, 60.f); PointF(40.f, 50.f); PointF(130.f, 60.f); PointF(200.f, 200.f)|]
let mutable movingPoint = -1
let draw = Drawable()
let menuBezier = new CheckMenuItem(Text="Show &Bezier", Checked=true)
let menuCanonical = new CheckMenuItem(Text="Show &Canonical spline")
let menuControlPoints = new CheckMenuItem(Text="Show control &points")

let tension = new Slider(Orientation=Orientation.Vertical, MinValue=0, MaxValue=10, Visible=false)

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    0 // return an integer exit code

