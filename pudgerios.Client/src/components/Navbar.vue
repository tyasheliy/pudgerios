<template>
	<nav class = 'navbar navbar-expand-lg navbar-dark bg-transparent'>
		<div class = 'container-fluid d-flex'>
			<router-link to = '/' class = 'navbar-brand'>Pudgerios Hotel</router-link>
			<ul class='navbar-nav me-auto'>
				<li class='nav-item'><a href = '#' class = 'nav-link'>Об отеле</a></li>
				<li class = 'nav-item'><a href = '#' class = 'nav-link'>События</a></li>
				<li class = 'nav-item'><a href = '#' class = 'nav-link'>Номера</a></li>
				<li class = 'nav-item'><a href = '#' class = 'nav-link'>Питание и развлечение</a></li>
				<li class = 'nav-item'><a href = '#' class = 'nav-link'>Контакты</a></li>
			</ul>
		</div>
	</nav>
</template>

<script>
export default{
	mounted(){
		if (this.$route.path != '/'){
			const nav = document.querySelector('nav');
			nav.classList.remove('bg-transparent');
			nav.classList.add('bg-dark');
			nav.classList.add('dark');
		}
	}
}
</script>
<style>
	.navbar-brand.navbar-brand {
		font-size: 36px;
	}

	.nav-link.nav-link {
		color: white;
		font-size: 26px;
	}

	.nav-item.nav-item {
		margin-left: 6px;
	}

	.dark {
		position: sticky !important;
		top: 0;
		left: 0;
		z-index: 2;
	}
</style>
