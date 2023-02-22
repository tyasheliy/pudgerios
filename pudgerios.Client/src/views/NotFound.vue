<template>
	<Navbar/>
		<div class = 'd-flex justify-content-center frame'>
			<span class = 'display-1'>Страница не найдена!</span>
		</div>
	<Footer/>
</template>	

<script>
	import Navbar from '../components/Navbar.vue'
	import Footer from '../components/Footer.vue'

	export default {
		components: {
			Navbar,
			Footer
		}
	}
</script>
