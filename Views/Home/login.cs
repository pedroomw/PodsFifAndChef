@{
    ViewData["Title"] = "login";
}
<main
<h1>Han pasado horas. Sigues encerrado en la cocina de Hank's Kitchen. Hank vigila la puerta. Hank se durmió y es tu chance de escaparte.</h1>
<p> Encuentra la llave para salir.</p>


 <form action='@Url.Action("SiguienteNivel", "Home")' method="post" enctype="multipart/form-data">
       <input type = "hidden" name = "respuesta" value = "1">
       <button class= "pillar-llave-btn" type="submit">Pillar llave</button>
          </form>
</main>