namespace Plotly.NET


/// Legend 
type Legend() = 
    inherit DynamicObj ()

    /// Init Legend type
    static member init (applyStyle:Legend->Legend) = 
        Legend() |> applyStyle

/// Margin 
type Margin() = 
    inherit DynamicObj ()

    /// Init Margin type
    static member init
        (
            ?Left   ,
            ?Right  ,
            ?Top    ,
            ?Bottom ,
            ?Pad    ,
            ?Autoexpand
        ) =
            Margin()
            |> Margin.style
                (
                    ?Left       = Left       ,
                    ?Right      = Right      ,
                    ?Top        = Top        ,
                    ?Bottom     = Bottom     ,
                    ?Pad        = Pad        ,
                    ?Autoexpand = Autoexpand                
                )


    // Applies the styles to Margin()
    static member style
        (
            ?Left   ,
            ?Right  ,
            ?Top    ,
            ?Bottom ,
            ?Pad    ,
            ?Autoexpand
        ) =
            (fun (margin:Margin) -> 
                Left   |> DynObj.setValueOpt margin "l"
                Right  |> DynObj.setValueOpt margin "r"
                Top    |> DynObj.setValueOpt margin "t"
                Bottom |> DynObj.setValueOpt margin "b"

                Pad        |> DynObj.setValueOpt margin "pad"
                Autoexpand |> DynObj.setValueOpt margin "autoexpand"

                margin
                )


/// Text annotations inside a plot 
type Annotation() = 
    inherit DynamicObj ()

    /// Init Annotation type
    static member init 
        (
            X               : float,
            Y               : float,
            ?XRef,
            ?YRef,
            ?ArrowTailX     : float,
            ?ArrowTailY     : float,
            ?ShowArrow      : bool,
            ?ArrowColor,
            ?ArrowHead      : StyleParam.ArrowHead,
            ?ArrowSize      : float,
            ?ArrowWidth     : float,
            ?Z              : float,
            ?Text           : string,
            ?TextAngle      : float,
            ?Font           : Font,
            ?Width          : float,
            ?Height         : float,
            ?Opacity        : float,
            ?HorizontalAlign: StyleParam.HorizontalAlign,
            ?VerticalAlign  : StyleParam.VerticalAlign,
            ?BGColor,
            ?BorderColor,
            ?Visible        : bool
        ) =
            Annotation()
            |> Annotation.style
                (
                    X                = X               ,
                    Y                = Y               ,
                    ?XRef            = XRef            ,
                    ?YRef            = YRef            ,
                    ?ArrowTailX      = ArrowTailX      ,
                    ?ArrowTailY      = ArrowTailY      ,
                    ?ShowArrow       = ShowArrow       ,
                    ?ArrowColor      = ArrowColor      ,
                    ?ArrowHead       = ArrowHead       ,
                    ?ArrowSize       = ArrowSize       ,
                    ?ArrowWidth      = ArrowWidth      ,
                    ?Z               = Z               ,
                    ?Text            = Text            ,
                    ?TextAngle       = TextAngle       ,
                    ?Font            = Font            ,
                    ?Width           = Width           ,
                    ?Height          = Height          ,
                    ?Opacity         = Opacity         ,
                    ?HorizontalAlign = HorizontalAlign ,
                    ?VerticalAlign   = VerticalAlign   ,
                    ?BGColor         = BGColor         ,
                    ?BorderColor     = BorderColor     ,
                    ?Visible         = Visible        
                )

    static member style 
        (
            X               : float,
            Y               : float,
            ?XRef,
            ?YRef,
            ?ArrowTailX     : float,
            ?ArrowTailY     : float,
            ?ShowArrow      : bool,
            ?ArrowColor,
            ?ArrowHead      : StyleParam.ArrowHead,
            ?ArrowSize      : float,
            ?ArrowWidth     : float,
            ?Z              : float,
            ?Text           : string,
            ?TextAngle      : float,
            ?Font           : Font,
            ?Width          : float,
            ?Height         : float,
            ?Opacity        : float,
            ?HorizontalAlign: StyleParam.HorizontalAlign,
            ?VerticalAlign  : StyleParam.VerticalAlign,
            ?BGColor,
            ?BorderColor,
            ?Visible        : bool

        ) =
            (fun (ann:Annotation) ->
                X               |> DynObj.setValue ann "x"
                Y               |> DynObj.setValue ann "y"
                XRef            |> DynObj.setValueOpt ann "xref"
                YRef            |> DynObj.setValueOpt ann "yref"
                ArrowTailX      |> DynObj.setValueOpt ann "ax"
                ArrowTailY      |> DynObj.setValueOpt ann "ay"
                ArrowHead       |> DynObj.setValueOptBy ann "arrowhead" StyleParam.ArrowHead.convert
                ArrowSize       |> DynObj.setValueOpt ann "arrowsize"
                ArrowWidth      |> DynObj.setValueOpt ann "arrowwidth"
                ShowArrow       |> DynObj.setValueOpt ann "showarrow"
                ArrowColor      |> DynObj.setValueOpt ann "arrowcolor"
                Z               |> DynObj.setValueOpt ann "z"
                Text            |> DynObj.setValueOpt ann "text"
                TextAngle       |> DynObj.setValueOpt ann "textangle"
                Font            |> DynObj.setValueOpt ann "font"
                Width           |> DynObj.setValueOpt ann "width"
                Height          |> DynObj.setValueOpt ann "height"
                Opacity         |> DynObj.setValueOpt ann "opacity"
                HorizontalAlign |> DynObj.setValueOptBy ann "align" StyleParam.HorizontalAlign.convert
                VerticalAlign   |> DynObj.setValueOptBy ann "valign" StyleParam.VerticalAlign.convert
                BGColor         |> DynObj.setValueOpt ann "bgcolor"
                BorderColor     |> DynObj.setValueOpt ann "bordercolor"
                Visible         |> DynObj.setValueOpt ann "visible"

                ann
            )

/// Layout 
type Layout() = 
    inherit DynamicObj ()

    /// Init Layout type
    static member init
        (   
            ?Title      : string   ,
            ?Titlefont  : Font     ,
            ?Font       : Font     ,
            ?Showlegend : bool     ,
            ?Autosize      ,
            ?Width      : float   ,
            ?Height     : float   ,
            //?xAxis      : Axis.LinearAxis,
            //?yAxis      : Axis.LinearAxis,
            ?Legend        ,
            ?Annotations : seq<Annotation>  ,
            ?Margin        ,
                           
            ?Paper_bgcolor ,
            ?Plot_bgcolor  ,
            ?Hovermode     ,
            ?Dragmode      ,
                           
            ?Separators    ,
            ?Barmode       ,
            ?Bargap        , 
            ?Radialaxis    ,
            ?Angularaxis   ,
            ?Scene:Scene   ,
            ?Direction     ,
            ?Orientation   , 
            ?Shapes        ,
                           
            ?Hidesources   ,
            ?Smith         ,
            ?Geo           : Geo

        ) =
            Layout()
            |> Layout.style
                (
                    ?Title         = Title         ,
                    ?Titlefont     = Titlefont     ,
                    ?Font          = Font          ,
                    ?Showlegend    = Showlegend    ,
                    ?Autosize      = Autosize      ,
                    ?Width         = Width         ,
                    ?Height        = Height        ,
                    //?xAxis         = xAxis         ,
                    //?yAxis         = yAxis         ,
                    ?Legend        = Legend        ,
                    ?Annotations   = Annotations   ,
                    ?Margin        = Margin        ,
                                    
                    ?Paper_bgcolor = Paper_bgcolor ,
                    ?Plot_bgcolor  = Plot_bgcolor  ,
                    ?Hovermode     = Hovermode     ,
                    ?Dragmode      = Dragmode      ,
                               
                    ?Separators    = Separators    ,
                    ?Barmode       = Barmode       ,
                    ?Bargap        = Bargap        , 
                    ?Radialaxis    = Radialaxis    ,
                    ?Angularaxis   = Angularaxis   ,
                    ?Scene         = Scene         ,
                    ?Direction     = Direction     ,
                    ?Orientation   = Orientation   , 
                    ?Shapes        = Shapes        ,
                                      
                    ?Hidesources   = Hidesources   ,
                    ?Smith         = Smith         ,
                    ?Geo           = Geo                
                )

    // Applies the styles to Layout()
    static member style
        (   
            ?Title,
            ?Titlefont:Font,
            ?Font:Font,
            ?Showlegend:bool,
            ?Autosize:bool,
            ?Width,
            ?Height,
            //?xAxis:Axis.LinearAxis,//?xAxis2:Axis.LinearAxis,
            //?yAxis:Axis.LinearAxis,//?yAxis2:Axis.LinearAxis,
            ?Legend:Legend,
            // TODO: annotations
            ?Annotations,
            ?Margin:Margin,
                
            ?Paper_bgcolor,
            ?Plot_bgcolor,
            ?Hovermode:StyleParam.Hovermode,
            ?Dragmode:StyleParam.Dragmode,
                
            ?Separators,
            ?Barmode:StyleParam.Barmode,
            ?Bargap, // Some bar.. /box... is missing
            // bargroupgap
            //
            ?Radialaxis:Axis.RadialAxis,
            ?Angularaxis:Axis.AngularAxis,
            ?Scene:Scene,
            ?Direction:StyleParam.Direction,
            ?Orientation,
            ?Shapes:Shape seq,
                
            ?Hidesources,
            ?Smith,
            ?Geo:Geo

        ) =
            (fun (layout:Layout) -> 
                Title           |> DynObj.setValueOpt layout "title"
                Autosize        |> DynObj.setValueOpt layout "autosize"
                Width           |> DynObj.setValueOpt layout "width"
                Height          |> DynObj.setValueOpt layout "height"
                
                Paper_bgcolor   |> DynObj.setValueOpt layout "paper_bgcolor"
                Plot_bgcolor    |> DynObj.setValueOpt layout "plot_bgcolor"
                Separators      |> DynObj.setValueOpt layout "separators"
                Hidesources     |> DynObj.setValueOpt layout "hidesources"
                Smith           |> DynObj.setValueOpt layout "smith"
                Showlegend      |> DynObj.setValueOpt layout "showlegend"
                Hovermode       |> DynObj.setValueOptBy layout "hovermode" StyleParam.Hovermode.toString
                Dragmode        |> DynObj.setValueOptBy layout "dragmode" StyleParam.Dragmode.toString
                
                Geo             |> DynObj.setValueOpt layout "geo"
                
                Annotations     |> DynObj.setValueOpt layout "annotations"
                

                Direction       |> DynObj.setValueOptBy layout "direction" StyleParam.Direction.toString
                Orientation     |> DynObj.setValueOpt layout "orientation"
                Barmode         |> DynObj.setValueOptBy layout "barmode" StyleParam.Barmode.toString
                Bargap          |> DynObj.setValueOpt layout "bargap"
                Shapes          |> DynObj.setValueOpt layout "shapes"

                // Update
                Font        |> DynObj.setValueOpt layout "font"
                Titlefont   |> DynObj.setValueOpt layout "titlefont"
                Margin      |> DynObj.setValueOpt layout "margin"
                //xAxis       |> DynObj.setValueOpt layout "xaxis"
                //xAxis2      |> DynObj.setValueOpt layout "xaxis2"
                //yAxis       |> DynObj.setValueOpt layout "yaxis"
                //yAxis2      |> DynObj.setValueOpt layout "yaxis2"
                Legend      |> DynObj.setValueOpt layout "legend"
                Radialaxis  |> DynObj.setValueOpt layout "radialaxis"
                Angularaxis |> DynObj.setValueOpt layout "angularaxis"
                Scene       |> DynObj.setValueOpt layout "scene"
                //Shapes      |> Option.iter (updatePropertyValueAndIgnore layout <@ layout.shapes @>)

                //// xAxis 
                //match xAxis with
                //| Some xaxis -> match xaxis.TryGetValue ("anchor") with
                //                | None -> layout.SetValue("xaxis",xaxis)
                //                | Some anchor -> let anchor' = StyleParam.AxisAnchorId.parse (unbox anchor)
                //                                 let pname = StyleParam.AxisAnchorId.toPropertyName anchor'
                //                                 layout.SetValue(pname,xaxis)
                //| None -> ()

                //// yAxis 
                //match yAxis with
                //| Some yaxis -> match yaxis.TryGetValue ("anchor") with
                //                | None -> layout.SetValue("xaxis",yaxis)
                //                | Some anchor -> let anchor' = StyleParam.AxisAnchorId.parse (unbox anchor)
                //                                 let pname = StyleParam.AxisAnchorId.toPropertyName anchor'
                //                                 layout.SetValue(pname,yaxis)
                //| None -> ()


                layout
            )


    static member AddLinearAxis
        (   
            id   : StyleParam.AxisId,
            axis : Axis.LinearAxis
        ) =
            (fun (layout:Layout) -> 

                axis           |> DynObj.setValue layout (StyleParam.AxisId.toString id)

                layout
            )

    // Updates the style of current axis with given AxisId
    static member UpdateLinearAxisById
        (   
            id   : StyleParam.AxisId,
            axis : Axis.LinearAxis
        ) =
            (fun (layout:Layout) -> 

                let axis' = 
                  match layout.TryGetValue (StyleParam.AxisId.toString id) with
                  | Some a -> DynObj.combine (unbox a) axis
                  | None  -> axis :>  DynamicObj
                
                axis'           |> DynObj.setValue layout (StyleParam.AxisId.toString id)

                layout
            )

    static member AddScene 
        (
            name: string,
            scene:Scene
        ) =
            (fun (layout:Layout) -> 
                scene |> DynObj.setValue layout name
                layout
            )

    static member SetLayoutGrid 
        (
            grid: LayoutGrid
        ) =
            (fun (layout:Layout) ->
                grid |> DynObj.setValue layout "grid"
                layout
            )

    
    static member GetLayoutGrid 
        (
            grid: LayoutGrid
        ) =
            (fun (layout:Layout) ->
                grid |> DynObj.setValue layout "grid"
                layout
            )

    
    static member AddMap
        (   
            id   : int,
            map  : Geo
        ) =
            (fun (layout:Layout) -> 
                
                let key = if id < 2 then "geo" else sprintf "geo%i" id
                map |> DynObj.setValue layout key

                layout
            )

    // Updates the style of current axis with given AxisId
    static member UpdateMapById
        (   
           id   : int,
           map  : Geo
        ) =
            (fun (layout:Layout) -> 
                let key = if id < 2 then "geo" else sprintf "geo%i" id
                let geo' = 
                    match layout.TryGetTypedValue<Geo>(key) with
                    | Some a  -> DynObj.combine (unbox a) map
                    | None    -> map :> DynamicObj
                
                geo'|> DynObj.setValue layout key

                layout
            )
