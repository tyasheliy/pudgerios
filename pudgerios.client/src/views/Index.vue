<template>
	<div class = 'frame-1 text-center text-light'>
		<Navbar transparent />
		<span class = 'display-1 caption border border-light'>PUDGERIOS Hotel</span>
		<span class = 'display-2 caption'>Восторг без границ<br>Комфорт без компромиссов</span>		

		<img src = '../static/img/index1.png'>
	</div>
	<div class = 'frame-2 text-light'>
		<span class = 'caption border border-light display-4 my-4 mx-4'>PUDGERIOS Hotel</span>
		<p class = 'description-1'>Уютный и небольшой, окутанный атмосферой непринужденности, в которой каждый гость почувствует себя комфортно, отель располагает общими помещениями — холлом, администрацией и баром — отреставрированными умелой рукой венецианского архитектора Карло Скарпа.</p>
		<img src = '../static/img/index2.png'>
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
	.frame-1 {
		height: 100vh;
		width: 100%;
	}

	.frame-1 img{
		position: absolute;
		top: 0;
		left: 0;
		height: 100%;
		width: 100%;
		z-index: -1;
	}

	.frame-2 {
		height: 100%;
		width: 100%;
	}

	.frame-2 img {
		position: absolute;
		top: 100%;
		left: 0;
		width: 100%;
		height: 100%;
		z-index: -1;
	}

	.caption {
		position: relative;
		display: inline-block;
		margin-top: 3%;
		padding: 1% 2% 1% 2%;
	}

	.description-1 {
		font-size: 125%;
		display: block;
		position: relative;
		top: 0;
		left: 2%;
		width: 45%;
		border: 1px solid red;
	}
</style>
