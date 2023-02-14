<template>
	<div class = 'frame frame-1 text-center text-light'>
		<Navbar transparent />
		<span class = 'display-1 caption main-caption border border-light'>PUDGERIOS Hotel</span><br>
		<span class = 'display-2 caption'>Восторг без границ<br>Комфорт без компромиссов</span>		

		<img src = '../static/img/index1.png'>
	</div>
	<div class = 'frame frame-2 text-light'>
		<span class = 'caption border border-light display-4 my-4 mx-4'>PUDGERIOS Hotel</span>
		<p class = 'description-1'>Уютный и небольшой, окутанный атмосферой непринужденности, в которой каждый гость почувствует себя комфортно, отель располагает общими помещениями — холлом, администрацией и баром — отреставрированными умелой рукой венецианского архитектора Карло Скарпа.</p>
		<p class = 'description-2'>Кроме удобного лифта на верхние этажи ведет великолепная лестница — тоже произведение Скарпа. Тут вас ждут со вкусом оформленные номера с лучшими удобствами, которые обеспечат приятный отпуск.</p>
		<img src = '../static/img/index2.png'>
	</div>
	<div class = 'd-flex justify-content-center'>
		<div class = 'index-form'>
			aboba
		</div>
	</div>
	<div class = 'frame frame-3 text-light'>
		
		<img src = '../static/img/index3.png'>
	</div>
	<div class = 'frame frame-4 text-light'>
	
		<img src = '../static/img/index4.png'>
	</div>
	<div class = 'frame frame-5 text-light'>
	
		<img src = '../static/img/index5.png'>
	</div>
</template>

<script>
	import Navbar from '../components/Navbar.vue'

	export default {
		components: {
			Navbar
		}
	}
</script>

<style>
	.frame {
		width: 100%;
		height: 100vh;
	}

	.frame img {
		filter: brightness(40%);
	}

	.frame-1 img{
		position: absolute;
		top: 0;
		left: 0;
		height: 100%;
		width: 100%;
		z-index: -1;
	}

	.frame-2 img {
		position: absolute;
		top: 100%;
		left: 0;
		width: 100%;
		height: 100%;
		z-index: -1;
	}

	.frame-3 img {
		position: absolute;
		top: 200%;
		left: 0;
		width: 100%;
		height: 100%;
		z-index: -1;
	}

	.frame-4 img {
		position: absolute;
		top: 300%;
		left: 0;
		width: 100%;
		height: 100%;
		z-index: -1;
	}

	.frame-5 img {
		position: absolute;
		top: 400%;
		left: 0;
		width: 100%;
		height: 100%;
		z-index: -1;
	}

	.index-form {
		background: white;
		margin-top: -0.5%;
		height: 5%;
		width: 60%;
	}

	.caption {
		position: relative;
		display: inline-block;
		margin-top: 3%;
		padding: 1% 2% 1% 2%;
	}

	.main-caption {
		margin-top: 8.5%;
	}

	.description-1 {
		margin-top: 2%;
		font-size: 3vh;
		display: block;
		position: relative;
		top: 0;
		left: 2%;
		width: 45%;
	}

	.description-2 {
		margin-top: 5%;
		font-size: 3vh;
		display: block;
		position: relative;
		top: 0;
		left: 54%;
		width: 45%;
	}
</style>
