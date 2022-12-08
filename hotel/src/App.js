import './App.css';
import CheckOut from './pages/checkout/Checkout';
// components
import Header from './components/Header';
import Cards from './components/Cards';
import { FilterProvider } from './components/FilterContext';

function App() {
  return (
    <div className="App">
      {/* <CheckOut /> */}
      <FilterProvider>
				<Header />
				<Cards />
			</FilterProvider>
    </div>
  );
}

export default App;
