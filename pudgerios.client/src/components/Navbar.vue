<template>
	<nav :class="(transparent) ? 'navbar navbar-expand-lg navbar-dark bg-transparent' : 'navbar navbar-expand-lg navbar-dark bg-dark dark'">
		<div class = 'container'>
			<a href = '#' class = 'navbar-brand'>Pudgerios Hotel</a>
			<ul class='navbar-nav me-auto mx-3 mb-2 mb-lg-0'>
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
	props: {
		transparent: Boolean
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
		position: sticky;
		top: 0;
		left: 0;
	}
</style>
