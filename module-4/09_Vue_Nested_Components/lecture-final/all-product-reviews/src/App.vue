<template>
  <div id="app">
    
    <search-bar v-on:filter="handleFilter"><random-component /></search-bar>
    <product-review
      name="Cigar Parties for Dummies"
      description="Host and plan the perfect cigar party for all of your squirrelly friends."
      v-bind:filterText="filter">
      Some text to go into the slot
    </product-review>
    <product-review
      name="Tech Elevator Bootcamp Extravaganza"
      description="14 crazy weeks of fun and coding with an emphasis on the coding"
      v-bind:filterText="filter">
    </product-review>  
  </div>
</template>

<script>
import ProductReview from './components/ProductReview.vue';
import SearchBar from './components/SearchBar.vue';
import RandomComponent from './components/RandomComponent.vue'

export default {
  name: 'app',
  components: {
    ProductReview,
    SearchBar,
    RandomComponent
  },
  data() {
    return {
      filter: ''

    };
  },
  methods: {
    handleFilter(filterText){
      this.filter = filterText;
    }

  }
}
</script>

<style>
#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}

#app div.main {
  display: inline-block;
  width: 45%;
  padding: 1em;
  border: 1px black solid;
  border-radius: 5px;
  margin: 0 1em;
  vertical-align: top;
}
</style>
