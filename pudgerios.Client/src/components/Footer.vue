<template>
	<footer>
		<div class = 'row'>
			<div class = 'col-lg-6' id = 'footer-company-info'>
				<span class = 'display-4 footer-caption'>PUDGERIOS Hotel</span>
				<div id = 'footer-company-adres'>
					<p>ООО "Тяжелый"</p>
					<p>Ярославский бульвар, д.8, стр2 Ярославль, Россия, 150034 / +7 (495) 880 1500</p>
				</div>
			</div>
			<div class = 'col-lg-6' id = 'footer-right'>
				<ul>
					<li>ABOBA</li>
					<li>ABOBA</li>
					<li>ABOBA</li>
					<li>ABOBA</li>
					<li>ABOBA</li>
				</ul>
			</div>
		</div>
		<div class = 'footer-footer'>
			aboba
		</div>
	</footer>
</template>

<script>
export default {
	mounted(){
		if (this.$route.path === '/'){
			document.querySelector('footer').style.backgroundColor = '#47423F';
		}
		else {
			document.querySelector('footer').classList.add('bg-dark');
		}
	}
}
</script>

<style scoped>
	footer {
		width: 100%;
		height: 65vh;
		color: white;
		border-top: 1px solid white;
		text-align: center;
		overflow-x: hidden;
	}

	.footer-footer {
		position: relative;
		top: 29%;
		left: 0;
		height: 10%;
		width: 100%;
	}

	.footer-caption {
		padding: 1% 2% 1% 2%;
		border-top: 1px solid white;
		border-bottom: 1px solid white;
		border-right: 1px solid white;
	}

	#footer-company-info {
		margin-top: 4%;
		display: flex;
		flex-direction: column;
	}

	#footer-company-adres {
		margin-top: 8%;
		border-top: 1px solid white;
		border-bottom: 1px solid white;
		border-right: 1px solid white;
	}

	#footer-company-adres p:first-child {
		font-size: 2.5vw;	
	}

	#footer-company-adres p:last-child {
		font-size: 1.2vw;
	}

	#footer-right {
		margin-top: 4%;
	}
		
	#footer-right ul {
		list-style: none;
		text-align: left;
		border-left: 1px solid white;
		border-top: 1px solid white;
		border-bottom: 1px solid white;
	}
</style>
