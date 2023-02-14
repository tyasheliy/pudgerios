<template>
	<div class='frame frame-1 text-center text-light'>
		<Navbar transparent />
		<span class='display-1 caption main-caption border border-light'>PUDGERIOS Hotel</span><br>
		<span class='display-2 caption'>Восторг без границ<br>Комфорт без компромиссов</span>

		<img src='../static/img/index1.png'>
	</div>
	<div class='frame frame-2 text-light'>
		<span class='caption border border-light display-4 my-4 mx-4'>PUDGERIOS Hotel</span>
		<p class='description-1'>Уютный и небольшой, окутанный атмосферой непринужденности, в которой каждый гость
			почувствует себя комфортно, отель располагает общими помещениями — холлом, администрацией и баром —
			отреставрированными умелой рукой венецианского архитектора Карло Скарпа.</p>
		<p class='description-2'>Кроме удобного лифта на верхние этажи ведет великолепная лестница — тоже произведение
			Скарпа. Тут вас ждут со вкусом оформленные номера с лучшими удобствами, которые обеспечат приятный отпуск.
		</p>
		<img src='../static/img/index2.png'>
	</div>
	<div class='index-form'>
		<form>
			<div class='row'>
				<div class='col-3'>
					<span>Забронировать</span>
				</div>
				<div class='col-3'>
					<span><img /><input type='date' /></span>
				</div>
				<div class='col-3'>
					<span><img /><input type='date' /></span>
				</div>
				<div class='col-3'>
					<button type='submit'>Забронировать</button>
				</div>
			</div>
		</form>
	</div>
	<div class='frame frame-3 text-light'>
		<div class='div-caption'>
			<div class='row'>
				<div class='col-6 border border-light'>
					<span class='text-light'>Номера</span>
				</div>
				<div class='col-6 bg-light'>
					<span><a class='text-dark' href='#'>Все номера</a></span>
				</div>
			</div>
		</div>
		<div id = 'frame-3-cards'>
		<div class='container'>
			<div class='row'>
				<div class = 'col-md-4'>
					<Typecard 
						image="luxe.png"
						caption="Аппартаменты класса Luxe"
						view="Вид на море"
						size="150 m2"
						suits="до 4 человек"
						food="Питание полное"
						link="#"
					/>
				</div>
				<div class = 'col-md-4'>
					<Typecard
						image="gold.png"
						caption="Аппартаменты класса Gold"
						view="Вид на море"
						size="200 m2"
						suits="До 6 человек"
						food="Питание полное"
						link="#"
					/>
				</div>
				<div class = 'col-md-4'>
					<Typecard
						image="gold.png"
						caption="Аппартаменты класса Platina"
						view="Вид на море"
						size="250 m2"
						suits="До 8 человек"
						food="Питание полное"
						link="#"
					/>
				</div>
			</div>
		</div>
		</div>
		<img src='../static/img/index3.png'>
	</div>
	<div class='frame frame-4 text-light'>

		<img src='../static/img/index4.png'>
	</div>
	<div class='frame frame-5 text-light'>

		<img src='../static/img/index5.png'>
	</div>
</template>

<script>
	import Navbar from '../components/Navbar.vue'
	import Typecard from '../components/Typecard.vue'

	export default {
		components: {
			Navbar,
			Typecard
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

	.frame-1 img {
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

	#frame-3-cards {
		position: relative;
		top: 12%;
		left: 0;
		width: 100%;
		height: 70%;
		overflow: auto;
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
		position: absolute;
		background: white;
		top: 196%;
		left: 20%;
		height: 8%;
		width: 60%;
	}

	.caption {
		position: relative;
		display: inline-block;
		margin-top: 3%;
		padding: 1% 2% 1% 2%;
	}

	.div-caption {
		position: relative;
		top: 5%;
		left: 0;
		padding: 1% 2% 1% 2%;
		width: 40%;
		text-align: center;
		vertical-align: middle;
		line-height: 400%;
	}

	.div-caption span {
		font-size: 4vw;
	}

	.div-caption span a {
		text-decoration: none;
		font-size: 2vw;
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

	@media (max-width: 991.98px) {
		.index-form {
			display: none;
		}

		.description-1,
		.description-2 {
			font-size: 2vh;
		}
	}

	@media (max-width: 575.98px) {

		.description-1,
		.description-2 {
			font-size: 100%;
		}
	}

	@media (max-width: 767.98px) {
		.div-caption span a {
			font-size: 75%;
		}
	}
</style>
