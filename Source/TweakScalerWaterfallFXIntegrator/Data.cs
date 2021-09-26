﻿/*
	This file is part of TweakScalerModuleWaterfallFXIntegrator, a component of TweakScaleCompanion_Frameworks
	© 2021 LisiasT : http://lisias.net <support@lisias.net>

	TweakScaleCompanion_Frameworks is double licensed, as follows:

	* SKL 1.0 : https://ksp.lisias.net/SKL-1_0.txt
	* GPL 2.0 : https://www.gnu.org/licenses/gpl-2.0.txt

	And you are allowed to choose the License that better suit your needs.

	TweakScaleCompanion_Frameworks is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the SKL Standard License 1.0
	along with TweakScaleCompanion_Frameworks. If not, see <https://ksp.lisias.net/SKL-1_0.txt>.

	You should have received a copy of the GNU General Public License 2.0
	along with TweakScaleCompanion_Frameworks. If not, see <https://www.gnu.org/licenses/>.

*/
using UnityEngine;

namespace TweakScaleCompanion.Frameworks.Waterfall.Integrator
{
	internal class Data
	{
		public readonly global::Waterfall.WaterfallEffect fx;
		public readonly Vector3 meshScale;
		public readonly Vector3 position;

		public Data(global::Waterfall.WaterfallEffect fx)
		{
			this.fx = fx;
			this.meshScale = fx.TemplateScaleOffset;
			this.position = fx.TemplatePositionOffset;
		}
	}
}
