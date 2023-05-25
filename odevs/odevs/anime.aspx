<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="anime.aspx.cs" Inherits="odevs.anime" %>

<html lang="en">
<head>
    <meta charset="UTF-8">
    
    <title>Document</title>
    <style>
       .kutu1 {
  width: 300px;
  height: 500px;
  background-color: red;
}

.kutu2 {
  width: 900px;
  height: 700px;
  background-color: green;
}
.yuklemedış{
   border: 6px solid black;
    width: 800px;
    height: 100px;
    border-radius: 90px;
}
.yuklemeiç{
    width: 300px;
    height: 60px;
    background-color: blue;
   left: 20px;
    border-radius: 90px;
    top: 20px;
    position: relative;
    animation-name:animes;
    animation-duration:1200ms;
   animation-iteration-count:infinite;

}
@keyframes animes{
    from{
        left: 20px;
    }
    to{
        left: 470px;
    }
}


    </style>
</head>
<body>
    <div id="kutu" class="kutu1"></div>
<script>


    document.getElementById('kutu').addEventListener('click', function() {
  kutu.classList.toggle('kutu2');
});

</script>
<div class="yuklemedış">
    <div class="yuklemeiç"></div>
</div>
    


</body>
</html>
