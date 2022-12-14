// dependencies
import React from 'react';
import styled from 'styled-components';
import Filters from './Filters';
import FilterText from './FilterText';


const HeroContainer = styled.section`
	margin: 0;
	padding: 3%;
	display: flex;
	flex-direction: column;
	justify-content: center;
	/*color: #457b9d;*/
	
	color: #E74C3C;
	text-align: center;
`;

const Header = () => {

	return (
		<header>
			<HeroContainer>
				<h1>Hotel Santa Cruz</h1>
				<br />
				<FilterText/>
				
			</HeroContainer>
			<Filters />
		</header>
	);
};

export default Header;
